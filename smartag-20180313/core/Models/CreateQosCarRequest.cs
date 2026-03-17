// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateQosCarRequest : TeaModel {
        /// <summary>
        /// <para>The description of the traffic throttling rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qosdesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the traffic throttling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Absolute</b>: throttles traffic based on a specific range of bandwidth values.</description></item>
        /// <item><description><b>Percent</b>: throttles traffic based on a specific range of bandwidth percentage.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Absolute</para>
        /// </summary>
        [NameInMap("LimitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth value. The value must be an integer. Unit: Mbit/s.</para>
        /// <para>This parameter is returned when <b>LimitType</b> is set to <b>Absolute</b>.</para>
        /// <remarks>
        /// <para> The maximum bandwidth value must be greater than the minimum bandwidth value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("MaxBandwidthAbs")]
        [Validation(Required=false)]
        public int? MaxBandwidthAbs { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth percentage. Unit: percent (%). Valid values: <b>1 to 100</b>.</para>
        /// <para>This parameter is required when you set <b>LimitType</b> to <b>Percent</b>.</para>
        /// <remarks>
        /// <para> The maximum bandwidth percentage must be greater than the minimum bandwidth percentage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("MaxBandwidthPercent")]
        [Validation(Required=false)]
        public int? MaxBandwidthPercent { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth value. The value must be an integer. Unit: Mbit/s.</para>
        /// <para>This parameter is returned when <b>LimitType</b> is set to <b>Absolute</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinBandwidthAbs")]
        [Validation(Required=false)]
        public int? MinBandwidthAbs { get; set; }

        /// <summary>
        /// <para>The minimum bandwidth percentage. Unit: percent (%). Valid values: <b>1 to 100</b>.</para>
        /// <para>This parameter is required when you set <b>LimitType</b> to <b>Percent</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MinBandwidthPercent")]
        [Validation(Required=false)]
        public int? MinBandwidthPercent { get; set; }

        /// <summary>
        /// <para>The name of the traffic throttling rule.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The type of bandwidth when traffic is throttled based on bandwidth percentage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CcnBandwidth</b>: CCN bandwidth</description></item>
        /// <item><description><b>InternetUpBandwidth</b>: total Internet bandwidth</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CcnBandwidth</para>
        /// </summary>
        [NameInMap("PercentSourceType")]
        [Validation(Required=false)]
        public string PercentSourceType { get; set; }

        /// <summary>
        /// <para>The priority of the traffic throttling rule.</para>
        /// <para>Valid values: <b>1</b> to <b>3</b>. A smaller value indicates a higher priority. If rules have the same priority, the one created the earliest is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-xitd8690ucu8ro****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the QoS policy belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
