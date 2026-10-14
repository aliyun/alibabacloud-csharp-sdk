// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveVSwitchesFromEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The Edge Private Network (EPN) instance ID. The NetworkingModel of the EPN instance must be Connection or SpeedUpAndConnection. The SpeedUp pattern does not support vSwitch operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-****</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The internal network configuration information to remove.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;}]</para>
        /// </summary>
        [NameInMap("VSwitchesInfo")]
        [Validation(Required=false)]
        public string VSwitchesInfo { get; set; }

    }

}
