# RDLC Report Header

You can create headers for RDLC reports. To do so, open the report in designer:

- Right-click on the report → Insert → Page Header. 
- In the Page header, put the contents which you are going to have in all pages. (Header 1 in screenshot)
- In the body, above the table, put the consents which you are going to have in the first page. (Header 2 in screenshot)

In fact whatever you put in the content part out side of the table, will not repeat on pages. and will not occupy space after the first page.

The same thing which we did using `Header2` can be done by inserting an unbound row as first row of the table.

**Design View** 

![enter image description here](report-design.png)

**Page 1**

![enter image description here](page1.png)

**Page 2**

![enter image description here](page2.png)


  [1]: https://i.stack.imgur.com/sAS2k.png
  [2]: https://i.stack.imgur.com/kb39R.png
  [3]: https://i.stack.imgur.com/GWrpg.png