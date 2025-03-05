// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class GetIpamPoolNextAvailableCidrResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>172.68.0.0/26</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>29FC6758-9B7C-5CC7-8CBF-4DD846FE7D82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
