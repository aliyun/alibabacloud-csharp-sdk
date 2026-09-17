// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <para>Specifies whether Chinese is included. This parameter is required only when the <b>type</b> parameter is set to <b>text</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Chinese is included.</description></item>
        /// <item><description>false: Chinese is not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The field embedding type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentloop-embedding-v4</para>
        /// </summary>
        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        /// <summary>
        /// <para>The JSON subfields. This parameter takes effect only when type is set to json.</para>
        /// </summary>
        [NameInMap("jsonKeys")]
        [Validation(Required=false)]
        public Dictionary<string, IndexJsonKey> JsonKeys { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
