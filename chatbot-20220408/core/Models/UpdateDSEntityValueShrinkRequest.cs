// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateDSEntityValueShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If this parameter is not set, the default business space is accessed. Obtain the key value from the business management page of the main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>When the entity type is synonyms, this parameter specifies the normalized value of the entity. When the entity type is regex, this parameter specifies the regular expression text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Book type</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The entity ID. This parameter can be left empty when you modify an entity member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223423423</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The entity member ID. This parameter is left empty when you create an entity member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2342377423</para>
        /// </summary>
        [NameInMap("EntityValueId")]
        [Validation(Required=false)]
        public long? EntityValueId { get; set; }

        /// <summary>
        /// <para>The chatbot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of synonyms.</para>
        /// </summary>
        [NameInMap("Synonyms")]
        [Validation(Required=false)]
        public string SynonymsShrink { get; set; }

    }

}
