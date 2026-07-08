// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartAuditRequest : TeaModel {
        /// <summary>
        /// <para>Parameters for image audit</para>
        /// </summary>
        [NameInMap("ImageUrlList")]
        [Validation(Required=false)]
        public List<SubmitSmartAuditRequestImageUrlList> ImageUrlList { get; set; }
        public class SubmitSmartAuditRequestImageUrlList : TeaModel {
            /// <summary>
            /// <para>Unique image identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The URL can be a web link or a base64-encoded string.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com/xxx.png">http://www.example.com/xxx.png</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Rule library ID for rule-based auditing (default: Default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>note_1_486</para>
        /// </summary>
        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        /// <summary>
        /// <para>List of sub-audit codes</para>
        /// </summary>
        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public List<string> SubCodes { get; set; }

        /// <summary>
        /// <para>Word library name for dictionary-based auditing (default: Default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("TermsName")]
        [Validation(Required=false)]
        public string TermsName { get; set; }

        /// <summary>
        /// <para>Content to be audited</para>
        /// 
        /// <b>Example:</b>
        /// <para>“你好呀”</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Workspace ID</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>Parameters for image audit (deprecated; use ImageUrlList instead)</para>
        /// </summary>
        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public List<SubmitSmartAuditRequestImageUrls> ImageUrls { get; set; }
        public class SubmitSmartAuditRequestImageUrls : TeaModel {
            /// <summary>
            /// <para>Unique image identifier</para>
            /// 
            /// <b>Example:</b>
            /// <para>3HAZTv62M0vkyz5B</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The URL can be a web link or a base64-encoded string.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/xxx.jpg">https://www.example.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
