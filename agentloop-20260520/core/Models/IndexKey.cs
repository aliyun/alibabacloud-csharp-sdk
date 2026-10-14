// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <para>Specifies whether the field contains Chinese characters. This parameter is required only when the <b>type</b> parameter is set to <b>text</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The field contains Chinese characters.</description></item>
        /// <item><description>false: The field does not contain Chinese characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>The field description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The embedding type of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentloop-embedding-v4</para>
        /// </summary>
        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        /// <summary>
        /// <para>The JSON subfields. This property takes effect only when the type is set to json.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;chn&quot;:true}}</para>
        /// </summary>
        [NameInMap("jsonKeys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        /// <summary>
        /// <para>The field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
