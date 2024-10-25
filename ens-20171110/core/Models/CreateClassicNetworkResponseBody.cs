// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClassicNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5s9ayrxsd9hszrlt5fgv2****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A004E06-AC1B-5806-BA5E-41AB6B02DE83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
