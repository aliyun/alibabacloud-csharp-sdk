// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>1d2db86sca4384811e0b5e8707e\<em>\</em>\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;es-cn-aaa&quot;,&quot;es-cn-bbb&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;,&quot;dev&quot;},{&quot;key&quot;:&quot;dev&quot;, &quot;value&quot;:&quot;IT&quot;}]</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[&quot;es-cn-aaa&quot;,&quot;es-cn-bbb&quot;]</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The header of the response. This parameter is empty and is for reference only. You cannot force this parameter to be relied on in the program.</para>
        /// <remarks>
        /// <para> The return examples does not contain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;env&quot;,&quot;value&quot;,&quot;dev&quot;},{&quot;key&quot;:&quot;dev&quot;,  &quot;value&quot;:&quot;IT&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
