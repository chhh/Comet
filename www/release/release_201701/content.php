<div id="page">
   <div id="content_full">
      <div class="post hr">
         <h1>Comet release 2017.01</h1>
            <ul>
               <b>release 2017.01 rev. 0 (2017.01.0), release date 2017/??/??</b>
               <li>Major update to code to add PSI's enhanced fasta format (PEFF) support.
                   Comet currently supports the ModRes and VariantSimple keywords only.  This
                   enables one to search annotated variable modifications and amino acid substitutions.
                   The ModRes modifications can be analyzed in conjunction with the
                   standard Comet variable modifications.
                   <br>&bullet; Note that the controls for Comet's standard
                   variable modifications (such as binary mods, force modification, etc.) only apply
                   to the standard variable modifications and not the PEFF mods.
                   <br>&bullet; For the VariantSimple amino acid substitutions, Comet will currently
                   only allow a single amino acid substitution in a peptide at a time.
                   <br>&bullet; PSI-Mod OBO entries must have "xref: DiffMono:".  UniMod OBO  entries must
                   have "xref: delta_mono_mass:".  Entries without these values are ignored.
                   <br>&bullet; Addition of <tt>source="peff"</tt> or <tt>source="param"</tt> attributes
                   to the <tt>mod_aminoacid_mass</tt> element in the pepXML output.
                   <br>&bullet; Addition of <tt>id</tt> attribute, referencing the modification ID from
                   the OBO file, to the <tt>mod_aminoacid_mass</tt> element in the pepXML output.
                   <br>&bullet; PEFF modifications will not be specified in the "search_summary" element at the
                   head of each pepXML file.
                   <br>&bullet; Note that any static mods are *always* applied and variable or PEFF
                   modification masses are added on top of static mods.
                   <br>&bullet; When a PEFF modification occurs at the same position as a PEFF variant,
                   the modification will be considered at that position on both the original residue
                   as well the variant residue.
                   <br>&bullet; The .out, .sqt, and .pin output formats currently expect a modification
                   character (e.g. * or #) to appear in the sequence for each variable modification.
                   This does not extend well to PEFF modifications so for these output formats, the
                   peptide string will replace these modification characters with the bracketed
                   modification mass e.g. "[79.9663]".
               <li>In pepXML modification output, 'static="<i>mass</i>"' and 'variable="<i>mass</i>'
                   are added to each "mod_aminoacid_mass" element.
               <li>Added a "verbose_output" hidden parameter.  This parameter controls whether or
                   not (default) extra diagnostic information is reported.  Currently it warns if
                   a PEFF modification does not have a mass difference entry or if a PEFF variant
                   is the same residue as in the original sequence.  This parameter is "hidden" in
                   that it is not written to the comet.params file generated by "comet -p" nor is it
                   present in the example comet.params files available for download.  To invoke this
                   parameter, a user must manually add "verbose_output = 1" to their comet.params file.
               <li>Comet now tracks and reports all duplicate protein entries.  The residues I and L
                   treated as being the same/equivalent.  You can turn off I/L equivalence by adding
                   an undocumented/hidden parameter "equal_I_and_L = 0".
               <li>Limit the number of permutations of modifications within a single peptide to 10,000.
                   This limit is separately applied to both variable modifications and PEFF modifications.
               <li>Change Crux compiled text output to also represent mass differences (e.g. M[15.9949])
                   instead of actual modified masses (e.g. M[147.0]) in the modified peptide string.
                   This brings it in line with the standard text output.  Additionally, both standard
                   and Crux versions will now report the mass differences to one decimal point.
               <li>I'm considering phasing out support for writing ".out" files.  The parameter entry
                   "output_outfiles" is no longer documented online nor written in the example params
                   files.  However, it is still functional if you add "output_outfiles = 1" manually
                   into your comet.params files.  If you still use ".out" files and would like support
                   for that format continued, email me directly.
                
            </ul>

            <p>Documentation for parameters for release 2017.01
            <a href="/parameters/parameters_201701/">can be found here</a>.

            <p>Go download from the <a href="https://sourceforge.net/projects/comet-ms/files/">download</a> page.

      </div>
   </div>

   <div style="clear: both;">&nbsp;</div>
</div>
