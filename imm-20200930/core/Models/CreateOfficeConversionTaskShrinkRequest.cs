// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateOfficeConversionTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The chained authorization configuration. This parameter is not required. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The end page for the document conversion. The default value is -1, which indicates that all pages from the start page to the last page are converted.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If the source file is a spreadsheet, you must specify the worksheet number (\<c>SheetIndex\\</c>).</para>
        /// </description></item>
        /// <item><description><para>If the document has many pages, we recommend that you convert them in batches. Otherwise, the conversion may time out.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when you convert the document to images. It does not take effect when you convert the document to a PDF file or a text file.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public long? EndPage { get; set; }

        /// <summary>
        /// <para>When you convert a spreadsheet document to images, specifies whether to return only the first image of the conversion result. The number of rows and columns in the image is the result of automatic splitting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. All images are returned.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. Only the first image is returned. This is used to extract a thumbnail.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if you set the <b>LongPicture</b> parameter to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FirstPage")]
        [Validation(Required=false)]
        public bool? FirstPage { get; set; }

        /// <summary>
        /// <para>When you convert a spreadsheet document to images or a PDF file, specifies whether to render all rows on a single image or PDF page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. The content is rendered on multiple images or PDF pages.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. The content is rendered on a single image or PDF page.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FitToHeight")]
        [Validation(Required=false)]
        public bool? FitToHeight { get; set; }

        /// <summary>
        /// <para>When you convert a spreadsheet document to images or a PDF file, specifies whether to render all columns on a single image or PDF page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. The content is rendered on multiple images or PDF pages.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. The content is rendered on a single image or PDF page.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FitToWidth")]
        [Validation(Required=false)]
        public bool? FitToWidth { get; set; }

        /// <summary>
        /// <para>When you convert a document to text, specifies whether to keep the line feeds in the document. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. Line feeds are not kept.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. Line feeds are kept.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HoldLineFeed")]
        [Validation(Required=false)]
        public bool? HoldLineFeed { get; set; }

        /// <summary>
        /// <para>The DPI of the output image. Valid values: 96 to 600. The default value is 96.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("ImageDPI")]
        [Validation(Required=false)]
        public long? ImageDPI { get; set; }

        /// <summary>
        /// <para>When you convert a document to images, specifies whether to convert it into a long image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. The document is converted into multiple images.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. The document is converted into a long image.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can combine a maximum of 20 pages into a long image. If the number of pages exceeds this limit, the conversion task may fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LongPicture")]
        [Validation(Required=false)]
        public bool? LongPicture { get; set; }

        /// <summary>
        /// <para>When you convert a document to text, specifies whether to convert it into a long text file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. Each page of the document is converted into a separate text file.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. All content is placed in a single text file.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LongText")]
        [Validation(Required=false)]
        public bool? LongText { get; set; }

        /// <summary>
        /// <para>The maximum number of columns to convert when you convert a spreadsheet document to images. By default, all columns are converted.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you set <b>LongPicture</b> to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSheetColumn")]
        [Validation(Required=false)]
        public long? MaxSheetColumn { get; set; }

        /// <summary>
        /// <para>The maximum number of rows to convert when you convert a spreadsheet document to images. By default, all rows are converted.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you set <b>LongPicture</b> to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxSheetRow")]
        [Validation(Required=false)]
        public long? MaxSheetRow { get; set; }

        /// <summary>
        /// <para>The message notification configuration. For more information, click Notification. For more information about the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743997.html">Asynchronous notification message format</a>.</para>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>The page numbers to convert. This parameter has a higher priority than the \<c>StartPage\\</c> and \<c>EndPage\\</c> parameters. The format is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Separate multiple page numbers with commas (,), for example, 1,2.</para>
        /// </description></item>
        /// <item><description><para>Specify a range of consecutive pages with a hyphen (-), for example, 1,2-4,7.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1,2-4,7</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// <para>When you convert a spreadsheet document to images, specifies whether to place the paper horizontally. The output image is similar to a printed page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. The paper is placed vertically.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. The paper is placed horizontally.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PaperHorizontal")]
        [Validation(Required=false)]
        public bool? PaperHorizontal { get; set; }

        /// <summary>
        /// <para>The paper size for converting a spreadsheet document to images. The output image is similar to a printed page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>A0</para>
        /// </description></item>
        /// <item><description><para>A2</para>
        /// </description></item>
        /// <item><description><para>A4 (default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when you use it with the <b>FitToHeight</b> and <b>FitToWidth</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>A4</para>
        /// </summary>
        [NameInMap("PaperSize")]
        [Validation(Required=false)]
        public string PaperSize { get; set; }

        /// <summary>
        /// <para>The password to open the document. Set this parameter if you want to convert a password-protected document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The project name. For more information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The quality of the converted file. Valid values: 0 to 100. A value of 0 indicates the lowest quality and the best performance. A value of 100 indicates the highest quality and the poorest performance. By default, the system sets an appropriate value based on the document content to balance quality and performance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        /// <summary>
        /// <para>The scaling ratio of the document. Valid values: 20 to 199. The default value is 100, which indicates that the document is not scaled.</para>
        /// <remarks>
        /// <para>A value less than 100 indicates that the document is scaled down. A value greater than 100 indicates that the document is scaled up.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ScalePercentage")]
        [Validation(Required=false)]
        public long? ScalePercentage { get; set; }

        /// <summary>
        /// <para>The number of worksheets to convert to images in the spreadsheet document. By default, all worksheets are converted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SheetCount")]
        [Validation(Required=false)]
        public long? SheetCount { get; set; }

        /// <summary>
        /// <para>The number of the worksheet to convert to images in the spreadsheet document. Valid values: 1 to the number of the last worksheet. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SheetIndex")]
        [Validation(Required=false)]
        public long? SheetIndex { get; set; }

        /// <summary>
        /// <para>When you convert a word processor document to images, specifies whether to show comments. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): No. Comments are not shown.</para>
        /// </description></item>
        /// <item><description><para>true: Yes. Comments are shown.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowComments")]
        [Validation(Required=false)]
        public bool? ShowComments { get; set; }

        /// <summary>
        /// <para>The extension type of the source data. By default, the type of the source data is determined by the extension of the OSS object. If the OSS object does not have an extension, you can set this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Word processor documents (Word): doc, docx, wps, wpss, docm, dotm, dot, and dotx</para>
        /// </description></item>
        /// <item><description><para>Presentation documents (PowerPoint): pptx, ppt, pot, potx, pps, ppsx, dps, dpt, pptm, potm, ppsm, and dpss</para>
        /// </description></item>
        /// <item><description><para>Spreadsheet documents (Excel): xls, xlt, et, ett, xlsx, xltx, csv, xlsb, xlsm, xltm, and ets</para>
        /// </description></item>
        /// <item><description><para>PDF documents: pdf</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doc</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The storage address of the source data.</para>
        /// <para>The OSS address must be in the oss\://${Bucket}/${Object} format. \<c>${Bucket}\\</c> is the name of the OSS bucket that is in the same region as the current project. \<c>${Object}\\</c> is the full path of the file, including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>A list of input images. The images are converted in the order of their URIs in the list. (<b>This parameter is not yet published. Do not use it.</b>)</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/test.pptx</para>
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        /// <summary>
        /// <para>The start page for the document conversion. The default value is 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If the source file is a spreadsheet, you must specify the worksheet number.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when you convert the document to images. It does not take effect when you convert the document to a PDF file or a text file.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public long? StartPage { get; set; }

        /// <summary>
        /// <para>The custom tags. The value is a dictionary. You can use tags to search for tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;key&quot;: &quot;value&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The type of the output file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>png: Converts the document to PNG images.</para>
        /// </description></item>
        /// <item><description><para>jpg: Converts the document to JPG images.</para>
        /// </description></item>
        /// <item><description><para>pdf: Converts the document to a PDF file.</para>
        /// </description></item>
        /// <item><description><para>txt: Converts the document to a text-only file. This is mainly used to extract text content from the file. This option is supported only for presentation documents, word processor documents, and spreadsheet documents. When you convert a spreadsheet document, a single txt file is generated, and settings for sheet-related variables do not take effect.</para>
        /// </description></item>
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
        /// <para>The template for the output address of the converted document.</para>
        /// <para>The address must be in the <c>oss://{bucket}/{tags.custom}/{dirname}/{barename}.{autoext}</c> format. For more information, see <a href="https://help.aliyun.com/document_detail/465762.html">TargetURI templates</a>.</para>
        /// <remarks>
        /// <para>Specify either this parameter or \<c>TargetURIPrefix\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputDocument.pdf</para>
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        /// <summary>
        /// <para>The prefix of the storage address for the output file after document conversion.</para>
        /// <para>The prefix must be in the <c>oss://${Bucket}/${Prefix}/</c> format. \<c>${Bucket}\\</c> is the name of the OSS bucket that is in the same region as the current project. \<c>${Prefix}\\</c> is the prefix of the storage address for the output file.</para>
        /// <remarks>
        /// <para>Specify either this parameter or \<c>TargetURI\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/outputprefix/</para>
        /// </summary>
        [NameInMap("TargetURIPrefix")]
        [Validation(Required=false)]
        public string TargetURIPrefix { get; set; }

        /// <summary>
        /// <para>The trimming policy for spreadsheet conversion. For example, if a spreadsheet contains many empty rows and columns, a large amount of white space may be generated if no trimming policy is specified.</para>
        /// </summary>
        [NameInMap("TrimPolicy")]
        [Validation(Required=false)]
        public string TrimPolicyShrink { get; set; }

        /// <summary>
        /// <para>The custom information. This information is returned in the asynchronous notification message to help you associate the notification with your services. The value can be up to 2,048 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;id&quot;: &quot;test-id&quot;,
        ///       &quot;name&quot;: &quot;test-name&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
