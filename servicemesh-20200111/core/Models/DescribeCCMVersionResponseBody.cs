// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeCCMVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The versions of the CCM component in all clusters on the data plane.</para>
        /// </summary>
        [NameInMap("CCMVersions")]
        [Validation(Required=false)]
        public Dictionary<string, CCMVersionsValue> CCMVersions { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
