// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateSolutionRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If this parameter is omitted, the system uses the default business space. You can obtain the key from the Business Management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The content of the knowledge answer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>答案内容</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The answer type. Valid values: <c>0</c> (plain text) and <c>1</c> (rich text).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public int? ContentType { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001905617</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <para>A list of perspective codes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PerspectiveCodes")]
        [Validation(Required=false)]
        public List<string> PerspectiveCodes { get; set; }

        /// <summary>
        /// <para>A list of tag IDs.</para>
        /// </summary>
        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

    }

}
