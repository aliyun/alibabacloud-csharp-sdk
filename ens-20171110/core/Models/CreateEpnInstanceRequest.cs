// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the EPN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test EPNInstanceName</para>
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// <para>The type of the EPN instance. Set the value to <b>EdgeToEdge</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EdgeToEdge</para>
        /// </summary>
        [NameInMap("EPNInstanceType")]
        [Validation(Required=false)]
        public string EPNInstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthByDay</b>: Pay by daily peak bandwidth.</description></item>
        /// <item><description><b>95BandwidthByMonth</b>: Pay by monthly 95th percentile bandwidth.</description></item>
        /// <item><description><b>PayByBandwidth4thMonth</b>: Pay by monthly fourth peak bandwidth.</description></item>
        /// <item><description><b>PayByBandwidth</b>: Pay by fixed bandwidth.</description></item>
        /// </list>
        /// <para>You can specify only one metering method for network usage and cannot overwrite the existing metering method.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthByDay</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The networking mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SpeedUp</b>: intelligent acceleration network (Internet)</description></item>
        /// <item><description><b>Connection</b>: internal network</description></item>
        /// <item><description><b>SpeedUpAndConnection</b>: intelligent acceleration network and internal network</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpeedUp</para>
        /// </summary>
        [NameInMap("NetworkingModel")]
        [Validation(Required=false)]
        public string NetworkingModel { get; set; }

    }

}
