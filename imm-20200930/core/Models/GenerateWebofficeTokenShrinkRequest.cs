// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateWebofficeTokenShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cache preview flag: </para>
        /// <list type="bullet">
        /// <item><description>true: When enabled, the document preview will no longer update collaborative editing content, suitable for scenarios where only preview is needed. </description></item>
        /// <item><description>false: When disabled, it defaults to collaborative preview, allowing the preview to synchronously update collaborative editing content.<remarks>
        /// <para>Notice: The price for cache preview and non-cache preview differs. Please refer to the billing item description for more details.</notice> &gt;Notice: Search and print functions are not supported during cache preview.</notice> <notice>Updating cached content is currently not supported in cache preview mode.</notice></para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true、false</para>
        /// </summary>
        [NameInMap("CachePreview")]
        [Validation(Required=false)]
        public bool? CachePreview { get; set; }

        /// <summary>
        /// <para><b>If there are no special requirements, leave this blank.</b></para>
        /// <para>Chained authorization configuration, not required. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Using Chained Authorization to Access Other Entity Resources</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>Indicates whether uploading a file with the same name to OSS is an expected behavior. Possible values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: Uploading a file with the same name to OSS is an expected behavior. The uploaded document will overwrite the original document and generate a new version. After setting it to true, you still need to close the currently editing document and wait for about 5 minutes before reopening it to load the new document. The upload is only effective when the document is closed; if the document is open, the new save will overwrite the uploaded file.</description></item>
        /// <item><description>false (default): Uploading a file with the same name to OSS is not an expected behavior, and the interface will return an error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExternalUploaded")]
        [Validation(Required=false)]
        public bool? ExternalUploaded { get; set; }

        /// <summary>
        /// <para>Filename, which must include the file extension. By default, it is the last segment of the <b>SourceURI</b> parameter.
        /// Supported file extensions (PDF is only supported for preview):</para>
        /// <list type="bullet">
        /// <item><description>Text documents (Word): doc, docx, txt, dot, wps, wpt, dotx, docm, dotm, rtf </description></item>
        /// <item><description>Presentation documents (PPT): ppt, pptx, pptm, ppsx, ppsm, pps, potx, potm, dpt, dps - Spreadsheet documents (Excel): et, xls, xlt, xlsx, xlsm, xltx, xltm, csv </description></item>
        /// <item><description>PDF documents: pdf</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-Object.pptx</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>Whether to hide the toolbar. This parameter can be set in document preview mode. Possible values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>false (default): Do not hide the toolbar.</description></item>
        /// <item><description>true: Hide the toolbar.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Hidecmb")]
        [Validation(Required=false)]
        public bool? Hidecmb { get; set; }

        /// <summary>
        /// <para>Notification message configuration, currently supporting only MNS. For the asynchronous notification message format, refer to <a href="https://help.aliyun.com/document_detail/2743999.html">WebOffice Message Notification Format</a>.</para>
        /// <remarks>
        /// <para>There will be message notifications when the file is saved or renamed.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        /// <summary>
        /// <para>Supports notifying some events to customers via MNS messages. This parameter is the topic for MNS asynchronous message notifications.</para>
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
        /// <para>If you need to preview or edit a password-protected document, set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>User permission information, represented in JSON format.</para>
        /// <para>User permissions include the following options:</para>
        /// <para>Each option is of type Boolean, with a default value of false, and can be set to true or false.</para>
        /// <list type="bullet">
        /// <item><description>Readonly (optional): Preview mode.</description></item>
        /// <item><description>Rename (optional): File renaming permission, which only provides message notification functionality. The renaming event will be sent to MNS.</description></item>
        /// <item><description>History (optional): Permission to view historical versions.</description></item>
        /// <item><description>Copy (optional): Copy permission.</description></item>
        /// <item><description>Export (optional): PDF export permission.</description></item>
        /// <item><description>Print (optional): Print permission.</description></item>
        /// </list>
        /// <remarks>
        /// <para>PDF only supports preview functionality, so the &quot;Readonly&quot; parameter must be set to true.</para>
        /// <para>PDF files do not support exporting.</para>
        /// <para>To use the multi-version feature, you must first enable the multi-version feature in OSS and then set the &quot;History&quot; parameter to true.</para>
        /// <para>Notice: Printing is not supported in cached preview.
        /// Notice: Historical versions can be viewed in edit mode but not in preview mode.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string PermissionShrink { get; set; }

        /// <summary>
        /// <para>Limits the number of pages that can be previewed. By default, there is no limit. The maximum cannot exceed 5000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PreviewPages")]
        [Validation(Required=false)]
        public long? PreviewPages { get; set; }

        /// <summary>
        /// <para>Project name, for how to obtain it, please refer to <a href="https://help.aliyun.com/document_detail/478153.html">Create Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>OSS anti-leeching. IMM needs to obtain the source file from OSS. If OSS has set up anti-leeching, IMM must pass the corresponding header to OSS to get the source file.</para>
        /// <remarks>
        /// <para>If the Bucket where the document is located has Referer set, please configure this parameter.</para>
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
        /// <para>OSS address of the document to be previewed or edited. The OSS address follows the rule <c>oss://${Bucket}/${Object}</c>, where <c>Bucket</c> is the name of the OSS Bucket in the same region as the current project, and <c>Object</c> is the full path of the file including the file extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.docx</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>User information. You can pass in user information from the business side, which will be displayed on the WebOffice page.</para>
        /// <para>The system distinguishes different users by User.Id, and User.Name is used only for front-end display. If User.Id is not provided, the backend will generate a random ID. Users with different IDs are considered different entities and cannot modify or delete each other\&quot;s comments.</para>
        /// <para>The default format is: Unknown_random string. If User.Id is not provided, the user information will default to &quot;Unknown&quot;.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string UserShrink { get; set; }

        /// <summary>
        /// <para>User-defined information. It only takes effect when Notification parameters are filled in for MNS configuration. It will be returned in asynchronous message notifications, which can help you correlate and process messages within your system. The maximum length is 2048 bytes.</para>
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
        /// <para>Watermark information. The watermark is generated on the front end and is not written into the source document. The same document with different parameters will result in different watermarks.</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public string WatermarkShrink { get; set; }

    }

}
