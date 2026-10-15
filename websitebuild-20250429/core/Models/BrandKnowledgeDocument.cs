// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeDocument : TeaModel {
        /// <summary>
        /// <para>Specifies whether the content is sufficient to be considered for plan summary candidates.</para>
        /// </summary>
        [NameInMap("ContentSufficient")]
        [Validation(Required=false)]
        public bool? ContentSufficient { get; set; }

        /// <summary>
        /// <para>The MIME type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/pdf</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The creation time in Unix milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>Specifies whether deletion is currently allowed.</para>
        /// </summary>
        [NameInMap("Deletable")]
        [Validation(Required=false)]
        public bool? Deletable { get; set; }

        /// <summary>
        /// <para>The display title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wanxiaozhi product introduction</para>
        /// </summary>
        [NameInMap("DisplayTitle")]
        [Validation(Required=false)]
        public string DisplayTitle { get; set; }

        /// <summary>
        /// <para>The document category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRODUCT</para>
        /// </summary>
        [NameInMap("DocCategory")]
        [Validation(Required=false)]
        public string DocCategory { get; set; }

        /// <summary>
        /// <para>The ID of the brand knowledge document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkd_3f7a1c2e9b7d4a5f8c0e1d2b3a4c5d6e</para>
        /// </summary>
        [NameInMap("DocumentId")]
        [Validation(Required=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// <para>The stable error code for main processing failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BRAND_KNOWLEDGE_PARSE_FAILED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The desensitized error message for main processing failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Document parsing failed. Please re-upload</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The file size in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1048576</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>The summary keywords.</para>
        /// </summary>
        [NameInMap("KeyTopics")]
        [Validation(Required=false)]
        public List<string> KeyTopics { get; set; }

        /// <summary>
        /// <para>The one-line summary, which is used only to construct search queries and cannot be used as factual evidence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Introduces the product positioning and core capabilities of the Wanxiaozhi AI website building platform. It can be used as a reference for content topic selection</para>
        /// </summary>
        [NameInMap("OneLineSummary")]
        [Validation(Required=false)]
        public string OneLineSummary { get; set; }

        /// <summary>
        /// <para>The original file name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wanxiaozhi product introduction.pdf</para>
        /// </summary>
        [NameInMap("OriginalName")]
        [Validation(Required=false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// <para>The ID of the business workspace. For GEO business workspaces of the brand marketing type, this is the appWorkspaceId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4e5f60718293a4b5c6d7e8f90a1b2c3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The time when the document is ready for reference, in Unix milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660900000</para>
        /// </summary>
        [NameInMap("ReadyAt")]
        [Validation(Required=false)]
        public long? ReadyAt { get; set; }

        /// <summary>
        /// <para>The document processing status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The message displayed on the status page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parsing completed and available for content plans</para>
        /// </summary>
        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// <para>The stable error code for summary failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BRAND_KNOWLEDGE_SUMMARY_TIMEOUT</para>
        /// </summary>
        [NameInMap("SummaryErrorCode")]
        [Validation(Required=false)]
        public string SummaryErrorCode { get; set; }

        /// <summary>
        /// <para>The summary status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("SummaryStatus")]
        [Validation(Required=false)]
        public string SummaryStatus { get; set; }

        /// <summary>
        /// <para>The last update time in Unix milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660900000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
