// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateCategoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public int? KnowledgeType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

    }

}
