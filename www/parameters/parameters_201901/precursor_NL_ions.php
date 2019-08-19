<?php include "head.php" ; ?>
<html>
<body>
<?php include "topmenu.php" ; ?>
<?php include "imgbar.php" ; ?>

<div id="page">
   <div id="content_full">
      <div class="post hr">

         <h2>Comet parameter: precursor_NL_ions</h2>

         <ul>
         <li>Controls whether or not precursor neutral loss peaks are considered in the xcorr scoring.
         <li>If left blank, this parameter is ignored.
         <li>To consider precursor neutral loss peaks, add one or more neutral loss mass value separated by a space.
         <li>As these neutral loss peaks are analyzed along side fragment ion peaks,
         the fragment tolerance settings (fragment_bin_tol, fragment_bin_offset, theoretical_fragment_ion)
         apply, I THINK!!
         <li>The default value is unused if this parameter is missing.
         </ul>

         <p>Example:
         <br><tt>precursor_NL_ions =</tt> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ... <i>entry blank; unused</i>
         <br><tt>precursor_NL_ions = 79.96633 97.97689</tt>

      </div>
   </div>
   <div style="clear: both;">&nbsp;</div>
</div>

<?php include "footer.php" ; ?>
</html>