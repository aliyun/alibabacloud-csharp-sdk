// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If you omit this parameter, the default business space is used. You can obtain the key on the Business Management page of your primary account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The knowledge type. Valid values: <c>1</c> (FAQ category) and <c>3</c> (document category). The default value is <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public int? KnowledgeType { get; set; }

        /// <summary>
        /// <para>The parent category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

    }

}
