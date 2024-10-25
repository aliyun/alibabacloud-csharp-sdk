// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssignPrivateIpAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ENI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-uf6533jbifugr5fo2j1w</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5rllcjb3ol6duzjdnbm1ombn7</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
