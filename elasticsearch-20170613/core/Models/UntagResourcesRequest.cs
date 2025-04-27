// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all parts. Default value: <b>false</b> . This parameter is valid only when <b>TagKeys</b> is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The resource list that you want to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;es-cn-09k1rocex0006****&quot;,&quot;es-cn-oew1rgiev0009****&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the resource. Fixed to <b>INSTANCE</b> .</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tags that you want to delete. The list can contain up to 20 subitems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;tagKey1&quot;,&quot;tagKey2&quot;]</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
