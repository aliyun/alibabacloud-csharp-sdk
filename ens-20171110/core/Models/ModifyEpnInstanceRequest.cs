// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EPN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epn-****</para>
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the EPN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens_test_epn</para>
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 1 Mbit/s to 100 Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The networking mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SpeedUp</b>: Intelligent acceleration network (Internet).</description></item>
        /// <item><description><b>Connection</b>: Internal network.</description></item>
        /// <item><description><b>SpeedUpAndConnection</b>: Intelligent acceleration network and internal network.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The internal network supports only <b>Connection</b> and <b>SpeedUpAndConnection</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SpeedUp</para>
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

    }

}
