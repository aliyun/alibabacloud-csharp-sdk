// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateOfficeConversionTaskRequest : TeaModel {
        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The ending page for document conversion. The default value is -1, which converts the file until the last page of the file.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the source is a spreadsheet file, specify the index number of the corresponding sheet instead.</para>
        /// </description></item>
        /// <item><description><para>If you convert a large number of pages within the document, we recommend that you split the pages into several document conversion tasks to prevent conversion timeouts.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when you convert the file into an image. It does not take effect when you convert the file into a PDF or TXT file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public long? EndPage { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only the first resulting image when you convert a spreadsheet document to images. The number of rows and the number of columns in the first image are determined by the automatic splitting process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not return only the first resulting image. All the resulting images are returned.</description></item>
        /// <item><description>true: returns only the first resulting image. A thumbnail is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>LongPicture</b> parameter is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FirstPage")]
        [Validation(Required=false)]
        public bool? FirstPage { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert all rows of a spreadsheet document to one single image or a single-page PDF document when you convert the table document to an image or a PDF document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): converts all rows of the document to multiple images or a multi-page PDF document. This is the default value.</description></item>
        /// <item><description>true: converts all rows of the document to one single image or a single-page PDF document.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FitToHeight")]
        [Validation(Required=false)]
        public bool? FitToHeight { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert all columns of a spreadsheet document to one single image or a single-page PDF document when you convert the spreadsheet file to an image or a PDF document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): converts all columns of the document to multiple images or a multi-page PDF document.</description></item>
        /// <item><description>true: converts all columns of the document to one single image or a single-page PDF document.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FitToWidth")]
        [Validation(Required=false)]
        public bool? FitToWidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain line feeds in the output file when a document is converted to a text file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not retain the line feeds.</description></item>
        /// <item><description>true: retains the line feeds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HoldLineFeed")]
        [Validation(Required=false)]
        public bool? HoldLineFeed { get; set; }

        /// <summary>
        /// <para>The dots per inch (DPI) of output images. Valid values: 96 to 600. Default value: 96.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("ImageDPI")]
        [Validation(Required=false)]
        public long? ImageDPI { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert the document to a long image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not convert the document to a long image.</description></item>
        /// <item><description>true: converts the document to a long image.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can convert up to 20 pages of a document into a long image. If you convert more than 20 pages to a long image, an error may occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LongPicture")]
        [Validation(Required=false)]
        public bool? LongPicture { get; set; }

        /// <summary>
        /// <para>Specifies whether to convert the document to a long text file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not convert the document to a long text file. Each page of the document is converted to a text file.</description></item>
        /// <item><description>true: converts the entire document to a long text file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LongText")]
        [Validation(Required=false)]
        public bool? LongText { get; set; }

        /// <summary>
        /// <para>The maximum number of spreadsheet columns to be converted to an image. By default, all columns within the spreadsheet file are converted.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>LongPicture</b> parameter is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSheetColumn")]
        [Validation(Required=false)]
        public long? MaxSheetColumn { get; set; }

        /// <summary>
        /// <para>The maximum number of spreadsheet rows to be converted to an image. By default, all rows within the spreadsheet file are converted.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>LongPicture</b> parameter is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSheetRow")]
        [Validation(Required=false)]
        public long? MaxSheetRow { get; set; }

        /// <summary>
        /// <para>The notification settings. For information about the asynchronous notification format, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous message examples</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>The numbers of pages to be converted. This parameter takes precedence over the StartPage and EndPage parameters. The value of this parameter can be in different formats:</para>
        /// <list type="bullet">
        /// <item><description>If you specify pages separately by page number, separate page numbers with commas (,). Example: 1,2</description></item>
        /// <item><description>If you specify consecutive pages by using a page range, connect the starting and ending page numbers with a hyphen (-). Example: 1,2-4,7</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2-4,7</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// <para>Specifies whether to place sheets of paper horizontally for converting a spreadsheet document to images. Conversion to images is similar to printing the content on a sheet of paper. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not place sheets of paper horizontally. Paper sheets are placed vertically.</description></item>
        /// <item><description>true: places sheets of paper horizontally.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PaperHorizontal")]
        [Validation(Required=false)]
        public bool? PaperHorizontal { get; set; }

        /// <summary>
        /// <para>The paper size for converting a spreadsheet document to images. Conversion to images is similar to printing the content on a sheet of paper. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>A0</description></item>
        /// <item><description>A2</description></item>
        /// <item><description>A4 (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>FitToHeight</b> and <b>FitToWidth</b> parameters are specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>A4</para>
        /// </summary>
        [NameInMap("PaperSize")]
        [Validation(Required=false)]
        public string PaperSize { get; set; }

        /// <summary>
        /// <para>The password that protects the source document. To convert a password-protected document, specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The quality of the output file. Valid values: 0 to 100. A smaller value indicates lower quality and better conversion performance. By default, the system specifies an appropriate value that provides an optimal balance between the quality and conversion performance based on the document content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// <para>The percentage scale relative to the source document. Valid values: 20 to 199. The default value is 100, which indicates that the document is not scaled.</para>
        /// <remarks>
        /// <para>A value that is less than 100 indicates a size reduction. A value that is greater than 100 indicates an enlargement.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ScalePercentage")]
        [Validation(Required=false)]
        public long? ScalePercentage { get; set; }

        /// <summary>
        /// <para>The number of sheets to be converted to an image. By default, all sheets within the spreadsheet file are converted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SheetCount")]
        [Validation(Required=false)]
        public long? SheetCount { get; set; }

        /// <summary>
        /// <para>The index number of the sheet to be converted to an image. The value ranges from 1 to the index number of the last sheet. By default, the conversion starts from the first sheet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SheetIndex")]
        [Validation(Required=false)]
        public long? SheetIndex { get; set; }

        /// <summary>
        /// <para>Specifies whether to display comments in resulting images when a text document is converted to images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not display comments in resulting images.</description></item>
        /// <item><description>true: displays comments in resulting images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowComments")]
        [Validation(Required=false)]
        public bool? ShowComments { get; set; }

        /// <summary>
        /// <para>The name extension of the source file. By default, the type of the source file is determined based on the name extension of the source object in OSS. If the object in OSS does not have a name extension, you can specify this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Text documents: doc, docx, wps, wpss, docm, dotm, dot, dotx, and html</description></item>
        /// <item><description>Presentation documents: pptx, ppt, pot, potx, pps, ppsx, dps, dpt, pptm, potm, ppsm, and dpss</description></item>
        /// <item><description>Spreadsheet documents: xls, xlt, et, ett, xlsx, xltx, csv, xlsb, xlsm, xltm, and ets</description></item>
        /// <item><description>PDF documents: pdf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doc</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The URI of the source file.</para>
        /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The list of images. The sequence of image URIs in the list determines the order in which they are converted. (<b>This parameter is not officially available and is not recommended.</b>)</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/test.pptx</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateOfficeConversionTaskRequestSources> Sources { get; set; }
        public class CreateOfficeConversionTaskRequestSources : TeaModel {
            /// <summary>
            /// <para>The rotation angle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (default)</description></item>
            /// <item><description>90</description></item>
            /// <item><description>180</description></item>
            /// <item><description>270</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Rotate")]
            [Validation(Required=false)]
            public long? Rotate { get; set; }

            /// <summary>
            /// <para>The OSS URI of the input image.</para>
            /// <para>The URI must be in the oss://${Bucket}/${Object} format. ${Bucket} specifies the name of the OSS bucket that is in the same region as the current project. ${Object} specifies the full path of the file that contains the file name extension.</para>
            /// <para>The operation supports the following image formats: JPG, JP2, PNG, TIFF, WebP, BMP, and SVG.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://examplebucket/sampleobject.jpg</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The starting page for document conversion. Default value: 1.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the document is a spreadsheet file, specify the index number of the corresponding sheet instead.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when you convert the file to an image format. It does not take effect when you convert the file into a PDF or TXT file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public long? StartPage { get; set; }

        /// <summary>
        /// <para>The custom tags in dictionary format. You can use the custom tags to search for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The format of the output file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>png: a PNG image.</description></item>
        /// <item><description>jpg: a JPG image.</description></item>
        /// <item><description>pdf: a PDF file.</description></item>
        /// <item><description>txt: a TXT file. You can specify this value to extract the text content of the source document. Only presentation, text, or spreadsheet documents can be converted to a TXT file. If the source document is a spreadsheet, only one TXT is created and sheet-related parameters do not take effect.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>png</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The address template of the output file.</para>
        /// <para>Specify the value in the <c>oss://{bucket}/{tags.custom}/{dirname}/{barename}.{autoext}</c> format. For more information, see <a href="https://help.aliyun.com/document_detail/465762.html">TargetURI template</a>.</para>
        /// <remarks>
        /// <para> Specify at least one of the TargetURI and TargetURIPrefix parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://{bucket}/{tags.custom}/{dirname}/{barename}.{autoext}</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The prefix of the storage address of the output file.</para>
        /// <para>Specify the prefix in the <c>oss://${Bucket}/${Prefix}/</c> format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Prefix}</c> is the prefix of the output file.</para>
        /// <remarks>
        /// <para> Specify at least one of the TargetURI and TargetURIPrefix parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket1/</para>
        /// </summary>
        [NameInMap("TargetURIPrefix")]
        [Validation(Required=false)]
        public string TargetURIPrefix { get; set; }

        /// <summary>
        /// <para>The trim policy for converting a spreadsheet file. Empty rows and columns may generate blank spaces in the output file if no appropriate trim policy is specified.</para>
        /// </summary>
        [NameInMap("TrimPolicy")]
        [Validation(Required=false)]
        public TrimPolicy TrimPolicy { get; set; }

        /// <summary>
        /// <para>The custom information, which is returned in an asynchronous notification and facilitates notification management. The maximum information length is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;file_id&quot;: &quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
