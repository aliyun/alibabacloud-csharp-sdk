// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerLogRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-uf6fonnghi50v6nq****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nginx</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the logs of the previous container if the container exits and restarts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LastTime")]
        [Validation(Required=false)]
        public bool? LastTime { get; set; }

        /// <summary>
        /// <para>The limit on the total size of logs. Unit: bytes. Valid values: 1 to 1048576(1 MB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123798</para>
        /// </summary>
        [NameInMap("LimitBytes")]
        [Validation(Required=false)]
        public long? LimitBytes { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the elastic container instance.</para>
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
        /// <para>A relative time in seconds before the current time from which to show logs. Examples: 10, 20, and 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SinceSeconds")]
        [Validation(Required=false)]
        public int? SinceSeconds { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the RFC 3339 standard. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-02T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The number of the most recent log entries that you want to query. Default value: 500. Maximum value: 2000.\
        /// A maximum of 1 MB log data can be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Tail")]
        [Validation(Required=false)]
        public int? Tail { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the timestamps of logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Timestamps")]
        [Validation(Required=false)]
        public bool? Timestamps { get; set; }

    }

}
