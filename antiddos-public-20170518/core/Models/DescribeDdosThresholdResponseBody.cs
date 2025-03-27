// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosThresholdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9B3C090-55AD-59C6-979E-FCFD81E7D9E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the details of the threshold.</para>
        /// </summary>
        [NameInMap("Thresholds")]
        [Validation(Required=false)]
        public DescribeDdosThresholdResponseBodyThresholds Thresholds { get; set; }
        public class DescribeDdosThresholdResponseBodyThresholds : TeaModel {
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public List<DescribeDdosThresholdResponseBodyThresholdsThreshold> Threshold { get; set; }
            public class DescribeDdosThresholdResponseBodyThresholdsThreshold : TeaModel {
                /// <summary>
                /// <para>If the value of the <b>DdosType</b> parameter is <b>defense</b>, the Bps parameter indicates the current traffic scrubbing threshold. Unit: Mbit/s.</para>
                /// <para>If the value of the <b>DdosType</b> parameter is <b>blackhole</b>, the Bps parameter indicates the basic protection threshold. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public int? Bps { get; set; }

                /// <summary>
                /// <para>The type of the threshold. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>defense</b>: traffic scrubbing threshold</description></item>
                /// <item><description><b>blackhole</b>: DDoS mitigation threshold</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>defense</para>
                /// </summary>
                [NameInMap("DdosType")]
                [Validation(Required=false)]
                public string DdosType { get; set; }

                /// <summary>
                /// <para>The burstable protection threshold (the maximum DDoS mitigation threshold). Unit: Mbit/s.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the value of the <b>DdosType</b> parameter is <b>blackhole</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12310</para>
                /// </summary>
                [NameInMap("ElasticBps")]
                [Validation(Required=false)]
                public int? ElasticBps { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp10bclrt56fblts****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                /// <summary>
                /// <para>Indicates whether the threshold is automatically adjusted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The scrubbing thresholds are automatically adjusted based on the traffic load on the asset.</description></item>
                /// <item><description><b>false</b>: The scrubbing thresholds are not automatically adjusted. You must manually specify the scrubbing thresholds.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsAuto")]
                [Validation(Required=false)]
                public bool? IsAuto { get; set; }

                /// <summary>
                /// <para>The maximum traffic scrubbing threshold. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("MaxBps")]
                [Validation(Required=false)]
                public int? MaxBps { get; set; }

                /// <summary>
                /// <para>The maximum packet scrubbing threshold. Unit: pps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150000</para>
                /// </summary>
                [NameInMap("MaxPps")]
                [Validation(Required=false)]
                public int? MaxPps { get; set; }

                /// <summary>
                /// <para>The packet scrubbing threshold. Unit: pps.</para>
                /// <remarks>
                /// <para>This parameter is returned only when the value of the <b>DdosType</b> parameter is <b>defense</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>150000</para>
                /// </summary>
                [NameInMap("Pps")]
                [Validation(Required=false)]
                public int? Pps { get; set; }

            }

        }

    }

}
