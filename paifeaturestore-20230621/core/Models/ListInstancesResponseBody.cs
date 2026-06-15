// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>Information about the FeatureDB instance.</para>
            /// </summary>
            [NameInMap("FeatureDBInfo")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesFeatureDBInfo FeatureDBInfo { get; set; }
            public class ListInstancesResponseBodyInstancesFeatureDBInfo : TeaModel {
                /// <summary>
                /// <para>The status of the FeatureDB instance.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Information about the FeatureDB instance.</para>
            /// </summary>
            [NameInMap("FeatureDBInstanceInfo")]
            [Validation(Required=false)]
            [Obsolete]
            public ListInstancesResponseBodyInstancesFeatureDBInstanceInfo FeatureDBInstanceInfo { get; set; }
            public class ListInstancesResponseBodyInstancesFeatureDBInstanceInfo : TeaModel {
                /// <summary>
                /// <para>The status of the FeatureDB instance.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-04T11:26:09.036+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>featureStore-cn-7mz2xfu****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region where the instance is located.</para>
            /// <list type="bullet">
            /// <item><description><para>cn-hangzhou</para>
            /// </description></item>
            /// <item><description><para>cn-beijing</para>
            /// </description></item>
            /// <item><description><para>cn-shanghai</para>
            /// </description></item>
            /// <item><description><para>cn-shenzhen</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// <list type="bullet">
            /// <item><description><para>Initializing</para>
            /// </description></item>
            /// <item><description><para>Running</para>
            /// </description></item>
            /// <item><description><para>Stopped</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Initializing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance type. Currently, only Basic is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CA11923-2A3D-5E5A-8314-E699D2DD15DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
