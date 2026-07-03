// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateQosCarResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the QoS rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qosdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of rate limiting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Absolute</b>: by bandwidth value.</para>
        /// </description></item>
        /// <item><description><para><b>Percent</b>: by percentage.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Percent</para>
        /// </summary>
        [NameInMap("LimitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth value. Unit: Mbit/s.</para>
        /// <para>This parameter is required when <b>LimitType</b> is set to <b>Absolute</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("MaxBandwidthAbs")]
        [Validation(Required=false)]
        public int? MaxBandwidthAbs { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth percentage. Unit: percent (%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("MaxBandwidthPercent")]
        [Validation(Required=false)]
        public int? MaxBandwidthPercent { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth value. Unit: Mbit/s.</para>
        /// <para>This parameter is required when <b>LimitType</b> is set to <b>Absolute</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinBandwidthAbs")]
        [Validation(Required=false)]
        public int? MinBandwidthAbs { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth percentage. Unit: percent (%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinBandwidthPercent")]
        [Validation(Required=false)]
        public int? MinBandwidthPercent { get; set; }

        /// <summary>
        /// <para>The bandwidth type when rate limiting by percentage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CcnBandwidth</b>: CCN bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>InternetUpBandwidth</b>: total Internet bandwidth.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CcnBandwidth</para>
        /// </summary>
        [NameInMap("PercentSourceType")]
        [Validation(Required=false)]
        public string PercentSourceType { get; set; }

        /// <summary>
        /// <para>The priority of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The instance ID of the QoS rate limiting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qoscar-n5k8g97lihlph****</para>
        /// </summary>
        [NameInMap("QosCarId")]
        [Validation(Required=false)]
        public string QosCarId { get; set; }

        /// <summary>
        /// <para>The instance ID of the QoS policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC13E8FF-4D61-40AD-868E-817F2D3AC86A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
