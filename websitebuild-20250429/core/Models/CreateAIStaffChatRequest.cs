// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAIStaffChatRequest : TeaModel {
        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The chat ID. Pass in this parameter to resume a conversation after an interruption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3b465fe1-6f06-4899-af9f-d43d9338df25</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b7105a2-2999-430b-ba23-ba09149d5434</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The list of conversation messages.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<CreateAIStaffChatRequestMessages> Messages { get; set; }
        public class CreateAIStaffChatRequestMessages : TeaModel {
            /// <summary>
            /// <para>The message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CodeRevision\&quot;: \&quot;1750040991876284109\&quot;}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/octet-stream</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The business extension metadata in Map format. The value must be a JSON string.</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetaData { get; set; }

            /// <summary>
            /// <para>The conversation role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx_dn</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The additional information for the conversation.</para>
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public Dictionary<string, string> MetaData { get; set; }

    }

}
