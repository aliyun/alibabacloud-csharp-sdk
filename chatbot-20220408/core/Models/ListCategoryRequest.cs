// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If not specified, the default business space is accessed. Obtain the key value from the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The knowledge type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: FAQ category.</description></item>
        /// <item><description>3: Document category.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public int? KnowledgeType { get; set; }

        /// <summary>
        /// <para>The ID of the parent category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

    }

}
