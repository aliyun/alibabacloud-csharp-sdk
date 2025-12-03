// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class DescribeVscMountPointsResponseBody : TeaModel {
        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<DescribeVscMountPointsResponseBodyMountPoints> MountPoints { get; set; }
        public class DescribeVscMountPointsResponseBodyMountPoints : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceTotalCount")]
            [Validation(Required=false)]
            public int? InstanceTotalCount { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeVscMountPointsResponseBodyMountPointsInstances> Instances { get; set; }
            public class DescribeVscMountPointsResponseBodyMountPointsInstances : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;ecs-instance1&quot;, &quot;ecs-instance2&quot;]</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Vscs")]
                [Validation(Required=false)]
                public List<DescribeVscMountPointsResponseBodyMountPointsInstancesVscs> Vscs { get; set; }
                public class DescribeVscMountPointsResponseBodyMountPointsInstancesVscs : TeaModel {
                    [NameInMap("VscId")]
                    [Validation(Required=false)]
                    public string VscId { get; set; }

                    [NameInMap("VscName")]
                    [Validation(Required=false)]
                    public string VscName { get; set; }

                    [NameInMap("VscStatus")]
                    [Validation(Required=false)]
                    public string VscStatus { get; set; }

                    [NameInMap("VscType")]
                    [Validation(Required=false)]
                    public string VscType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hdfs1</para>
            /// </summary>
            [NameInMap("MountPointAlias")]
            [Validation(Required=false)]
            public string MountPointAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>037cb49e1d-c***5</para>
            /// </summary>
            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
