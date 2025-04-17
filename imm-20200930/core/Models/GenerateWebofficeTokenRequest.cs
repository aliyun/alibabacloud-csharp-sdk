// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateWebofficeTokenRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable cache preview.</para>
        /// <list type="bullet">
        /// <item><description>true: enables cache preview. The document can be previewed only and cannot be collaboratively edited.</description></item>
        /// <item><description>false: does not enable cache preview. The document can be collaboratively edited when it is being previewed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The pricing for document previews varies based on whether cache preview is enabled or disabled.</para>
        /// </remarks>
        /// <remarks>
        /// <para> During a cache preview, document content search and printing are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CachePreview")]
        [Validation(Required=false)]
        public bool? CachePreview { get; set; }

        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The configurations of authorization chains. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow an upload of a document to the Object Storage Service (OSS) bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Documents can be directly uploaded to OSS. The uploaded document overwrites the existing document and a new version is generated for the document. Before you upload a new document, close the existing document if it is being edited. After the document is uploaded, wait for approximately 5 minutes before you open the document again so that the new version can successfully load. Upload a new document only when the existing is closed. Otherwise, the uploaded document is overwritten when the existing document is saved.</description></item>
        /// <item><description>false: Documents cannot be directly uploaded to OSS. If you try to upload a document, an error is returned. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExternalUploaded")]
        [Validation(Required=false)]
        public bool? ExternalUploaded { get; set; }

        /// <summary>
        /// <para>The name of the file. The extension must be included in the file name. By default, this parameter is set to the last depth level of the <b>SourceURI</b> parameter value.</para>
        /// <para>Supported extensions (only preview supported for .pdf):</para>
        /// <list type="bullet">
        /// <item><description>Word documents: .doc, .docx, .txt, .dot, .wps, .wpt, .dotx, .docm, .dotm, and .rtf</description></item>
        /// <item><description>Presentation documents: .ppt, .pptx, .pptm, .ppsx, .ppsm, .pps, .potx, .potm, .dpt, and .dps</description></item>
        /// <item><description>Table documents: .et, .xls, .xlt, .xlsx, .xlsm, .xltx, .xltm, and .csv</description></item>
        /// <item><description>PDF documents: .pdf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test.pptx</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Hidecmb")]
        [Validation(Required=false)]
        public bool? Hidecmb { get; set; }

        /// <summary>
        /// <para>The notification settings. Only SMQ messages are supported. For more information, see <a href="https://help.aliyun.com/document_detail/2743999.html">WebOffice message example</a>.</para>
        /// <remarks>
        /// <para> A notification is sent after the document is saved or renamed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>topic1</para>
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The user permission settings in the JSON format.</para>
        /// <para>The parameter supports the following permission fields:</para>
        /// <para>Each field is of type Boolean and can have a value of true and false (the default value):</para>
        /// <list type="bullet">
        /// <item><description>Readonly: grants the permission to preview the document. This field is optional.</description></item>
        /// <item><description>Rename: grants the permission to rename the document. Notification messages of a rename event can be sent only by using SMQ. This field is optional.</description></item>
        /// <item><description>History: grants the permission to view historical versions. This field is optional.</description></item>
        /// <item><description>Copy: grants the permission to copy the document. This field is optional.</description></item>
        /// <item><description>Export: grants the permission to export the document as a PDF file. This field is optional.</description></item>
        /// <item><description>Print: grants the permission to print the document. This field is optional.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only online preview is supported for PDF documents. When you call the operation on a PDF document, you can set Readonly only to true.</para>
        /// </remarks>
        /// <remarks>
        /// <para> To manage multiple versions of the document, you must enable versioning for the bucket that stores the document and set the History parameter to true.</para>
        /// </remarks>
        /// <remarks>
        /// <para> Printing is not supported during cache preview.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public WebofficePermission Permission { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PreviewPages")]
        [Validation(Required=false)]
        public long? PreviewPages { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/test.pptx</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The user information. The user information that you want to display on the WebOffice page. If you do not specify this parameter, the user name displayed is Unknown.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public WebofficeUser User { get; set; }

        /// <summary>
        /// <para>The user-defined data that you want to return in asynchronous messages. This parameter takes effect only when you specify the MNS settings in the Notification parameter. The maximum length of the value is 2,048 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;file_id&quot;: &quot;abc&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public WebofficeWatermark Watermark { get; set; }

    }

}
