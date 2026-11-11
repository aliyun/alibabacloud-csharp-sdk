// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IndexKey : TeaModel {
        /// <summary>
        /// <para>Specifies whether Chinese characters are included.</para>
        /// <list type="bullet">
        /// <item><description>true: Chinese characters are included.</description></item>
        /// <item><description>false: Chinese characters are not included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("chn")]
        [Validation(Required=false)]
        public bool? Chn { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v4</para>
        /// </summary>
        [NameInMap("embedding")]
        [Validation(Required=false)]
        public string Embedding { get; set; }

        /// <summary>
        /// <para>json key</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;message&quot;:{&quot;type&quot;:&quot;text&quot;,&quot;chn&quot;:true}}</para>
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
