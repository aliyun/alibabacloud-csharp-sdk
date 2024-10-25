// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public List<DescribeHaVipsResponseBodyHaVips> HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            [NameInMap("AssociatedEipAddresses")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses> AssociatedEipAddresses { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>47.XX.XX.40</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eip-5p1wz****</para>
                /// </summary>
                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

            }

            [NameInMap("AssociatedInstances")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedInstances> AssociatedInstances { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedInstances : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-05T07:09:28Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-51p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EnsInstance</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.XX.XX.9</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-29T11:17:38Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-guiyang-14</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>havip-52y28****</para>
            /// </summary>
            [NameInMap("HaVipId")]
            [Validation(Required=false)]
            public string HaVipId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.XX.XX.5</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-5wtkyrk****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-5yc8d****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
