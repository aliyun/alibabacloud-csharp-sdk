// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEpnInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Edge-to-Edge network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test EPNInstanceName</para>
        /// </summary>
        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        /// <summary>
        /// <para>The type of the Edge-to-Edge communication instance. Valid value: <b>EdgeToEdge</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EdgeToEdge</para>
        /// </summary>
        [NameInMap("EPNInstanceType")]
        [Validation(Required=false)]
        public string EPNInstanceType { get; set; }

        /// <summary>
        /// <para>The network billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthByDay</b>: Daily peak bandwidth.</description></item>
        /// <item><description><b>95BandwidthByMonth</b>: Monthly 95th percentile peak bandwidth.</description></item>
        /// <item><description><b>PayByBandwidth4thMonth</b>: Monthly fourth peak bandwidth.</description></item>
        /// <item><description><b>PayByBandwidth</b>: Bandwidth with defined specifications.</description></item>
        /// </list>
        /// <para>Only one of the Billable methods is supported. If a billing method already exists, the new value is invalid by default, and the existing one prevails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthByDay</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum outbound bandwidth to the Internet. Unit: Mbit/s. Valid values: 1 to 100.</para>
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
        /// <item><description><b>SpeedUp</b>: Intelligent acceleration (Internet).</description></item>
        /// <item><description><b>Connection</b>: Internal network connectivity (internal network mode).</description></item>
        /// <item><description><b>SpeedUpAndConnection</b>: Intelligent acceleration and internal network connectivity (internal network mode).</description></item>
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
