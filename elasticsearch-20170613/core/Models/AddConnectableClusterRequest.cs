// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class AddConnectableClusterRequest : TeaModel {
        /// <summary>
        /// <para>请求体。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;instanceId&quot;:&quot;es-cn-09k1rgid9000g****&quot; }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
