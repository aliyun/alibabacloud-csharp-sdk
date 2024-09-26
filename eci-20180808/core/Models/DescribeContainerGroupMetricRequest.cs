// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupMetricRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-bp17da5olmkuagfr****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The default value is the current time.</para>
        /// <para>Specify the time in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-12T01:05:00.000Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The data aggregation period. Unit: seconds. Valid values: 15, 30, 60, and 600. Default value: 60.</para>
        /// <remarks>
        /// <para> If the StartTime and EndTime parameters are not specified, the system returns the monitoring data generated in the last 5 minutes with a data aggregation period of 15s. The Period parameter is ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

        /// <summary>
        /// <para>The beginning of the time range to query. The beginning of the time range must be a time point in the last 30 days. The default value is 5 minutes before the value of EndTime.</para>
        /// <para>Specify the time in RFC 3339 format. For example, to query the data starting from March 12, 2019, 09:00 UTC+8, you can set the parameter to 2019-03-12T09:00:00.000+08:00 or 2019-03-12T01:00:00.000Z.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-12T01:00:00.000Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
