// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class JoinVSwitchesToEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The edge-to-edge communication instance ID.</para>
        /// <para>The NetworkingModel of the EPN instance must be Connection or SpeedUpAndConnection. The SpeedUp pattern does not allow you to associate vSwitches.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-xxxx</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The internal networking information to be added.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;},{&quot;VSwitchId&quot;:&quot;vs-ixxxx&quot;}]</para>
        /// </summary>
        [NameInMap("VSwitchesInfo")]
        [Validation(Required=false)]
        public string VSwitchesInfo { get; set; }

    }

}
