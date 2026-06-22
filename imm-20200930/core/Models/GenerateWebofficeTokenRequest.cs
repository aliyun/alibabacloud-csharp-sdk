// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateWebofficeTokenRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable cached preview.</para>
        /// <list type="bullet">
        /// <item><description>true: When enabled, the document preview no longer updates collaborative editing content. This is suitable for preview-only scenarios.</description></item>
        /// <item><description>false: When disabled, collaborative preview is used by default, which synchronizes collaborative editing content during preview.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Cached preview and non-cached preview have different unit prices. For more information, see the billing item description.
        /// </notice>&gt;Notice: Cached preview does not support document content search or printing.</notice>
        /// <notice>Cached preview does not support updating cached content.</notice>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CachePreview")]
        [Validation(Required=false)]
        public bool? CachePreview { get; set; }

        /// <summary>
        /// <para><b>Leave this parameter empty unless you have specific requirements.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether uploading a file with the same name to OSS is expected behavior. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uploading a file with the same name to OSS is expected behavior. The uploaded document overwrites the original document and generates a new version. After this parameter is set to true, you must first close the document that is being edited, wait about 5 minutes, and then reopen it to load the new document. The upload takes effect only when the document is closed. If the document is open, new saves overwrite the uploaded file.</description></item>
        /// <item><description>false (default): Uploading a file with the same name to OSS is not expected behavior. The operation returns an error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExternalUploaded")]
        [Validation(Required=false)]
        public bool? ExternalUploaded { get; set; }

        /// <summary>
        /// <para>The file name, which must include the file name extension. The default value is the last segment of the <b>SourceURI</b> parameter.</para>
        /// <para>Supported file name extensions (PDF supports preview only):</para>
        /// <list type="bullet">
        /// <item><description>Word documents: doc, docx, txt, dot, wps, wpt, dotx, docm, dotm, and rtf</description></item>
        /// <item><description>PowerPoint documents: ppt, pptx, pptm, ppsx, ppsm, pps, potx, potm, dpt, and dps</description></item>
        /// <item><description>Excel documents: et, xls, xlt, xlsx, xlsm, xltx, xltm, and csv</description></item>
        /// <item><description>PDF documents: pdf.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-Object.pptx</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>Specifies whether to hide the toolbar. This parameter is supported in document preview mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): The toolbar is not hidden.</para>
        /// </description></item>
        /// <item><description><para>true: The toolbar is hidden.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Hidecmb")]
        [Validation(Required=false)]
        public bool? Hidecmb { get; set; }

        /// <summary>
        /// <para>The notification configuration. Currently, only MNS is supported. For the format of asynchronous notification messages, see <a href="https://help.aliyun.com/document_detail/2743999.html">WebOffice message notification format</a>.</para>
        /// <remarks>
        /// <para>Message notifications are sent when a file is saved or renamed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        /// <summary>
        /// <para>Sends event notifications to you as MNS messages. This parameter specifies the MNS topic for asynchronous message notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-topic</para>
        /// </summary>
        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        /// <summary>
        /// <para>The password to open the document.</para>
        /// <remarks>
        /// <para>Set this parameter if you want to preview or edit a password-protected document.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The user permission information in JSON format.</para>
        /// <para>User permissions include the following options:</para>
        /// <para>Each option is of the Boolean type. The default value is false. Valid values: true and false.</para>
        /// <list type="bullet">
        /// <item><description><para>Readonly (optional): Preview mode.</para>
        /// </description></item>
        /// <item><description><para>Rename (optional): The permission to rename a file. Only message notification is provided. The rename event is sent to MNS.</para>
        /// </description></item>
        /// <item><description><para>History (optional): The permission to view historical versions.</para>
        /// </description></item>
        /// <item><description><para>Copy (optional): The copy permission.</para>
        /// </description></item>
        /// <item><description><para>Export (optional): The permission to export to PDF.</para>
        /// </description></item>
        /// <item><description><para>Print (optional): The print permission.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>PDF supports only the preview feature. You must set the Readonly parameter to true.</para>
        /// </remarks>
        /// <remarks>
        /// <para>PDF files do not support export.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To use the versioning feature, you must first enable versioning in OSS and then set the History parameter to true.</para>
        /// <para>Notice: Printing is not supported in cached preview.
        /// Notice: Historical versions can be viewed in edit mode but not in preview mode..</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public WebofficePermission Permission { get; set; }

        /// <summary>
        /// <para>The maximum number of pages that can be previewed. By default, no limit is imposed. The maximum value is 5,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PreviewPages")]
        [Validation(Required=false)]
        public long? PreviewPages { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS hotlink protection referer. Intelligent Media Management (IMM) needs to retrieve the source file from OSS. If hotlink protection is configured for OSS, IMM must pass the corresponding header to OSS to retrieve the source file.</para>
        /// <remarks>
        /// <para>Set this parameter if the bucket that stores the document has a referer configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        /// <summary>
        /// <para>The OSS URI of the document to preview or edit.</para>
        /// <para>The OSS URI follows the format <c>oss://${Bucket}/${Object}</c>, where <c>Bucket</c> is the name of an OSS bucket in the same region as the current project, and <c>Object</c> is the full path of the file including the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.docx</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The user information. You can pass in user information from the business side, and the WebOffice page displays this information.</para>
        /// <para>The system distinguishes different users by User.Id. User.Name is used only for frontend display. If User.Id is not specified, the backend automatically generates a random ID. Users with different IDs are treated as different principals and cannot modify or delete each other\&quot;s comments.</para>
        /// <para>The default format is: Unknown_RandomString. If User.Id is not specified, the user information is displayed as &quot;Unknown&quot; by default.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public WebofficeUser User { get; set; }

        /// <summary>
        /// <para>The custom user data. This parameter takes effect only when the Notification parameter is specified with MNS configurations. The data is returned in asynchronous message notifications for you to associate and process message notifications within your system. Maximum length: 2,048 bytes.</para>
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

        /// <summary>
        /// <para>The watermark information. The watermark is generated on the frontend and is not written to the source document. Different parameters passed for the same document produce different watermarks.</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public WebofficeWatermark Watermark { get; set; }

    }

}
