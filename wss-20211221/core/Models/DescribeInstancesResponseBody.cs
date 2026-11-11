// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of sold instances that meet the query conditions.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The expiration time in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The sold instance ID, which is used to identify the purchased instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-0bw2ew49****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance type identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd.graphics.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The list of instance properties. Each item contains the property name Key and the property value Value.</para>
            /// </summary>
            [NameInMap("PropertyList")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesPropertyList> PropertyList { get; set; }
            public class DescribeInstancesResponseBodyInstancesPropertyList : TeaModel {
                /// <summary>
                /// <para>The instance property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>regionId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The instance property value, which corresponds to the Key in the same entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The associated business resource ID, which is used to distinguish from the sold instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-7w78ozhj****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. For example, CorePackage indicates a core-hour package. It must be consistent with the resource type of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CorePackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The effective time in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: Normal.</description></item>
            /// <item><description>DELETED: Deleted.</description></item>
            /// <item><description>PENDING: Pending activation.</description></item>
            /// <item><description>EXPIRED: Expired.</description></item>
            /// <item><description>ARCHIVED: Historical archived status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The total metering quota included in the instance, using the same unit as UsedTime. A CorePackage core-hour package is metered in core-seconds. For example, 360000 indicates 100 core-hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360000</para>
            /// </summary>
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public int? TotalTime { get; set; }

            /// <summary>
            /// <para>The consumed metering quota of the instance. For a CorePackage core-hour package, the unit is core-seconds. Divide by 3600 to convert to core-hours. For other resource types, read according to the corresponding metering criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public int? UsedTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return per query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave it empty for the first query. For subsequent queries, pass the NextToken value returned in the previous response as is. Do not construct or decode it yourself.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to troubleshoot call issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72481C12-69AB-5CE1-8A35-A8EFA921****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
