// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeHaVipsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the HAVIPs.</para>
        /// </summary>
        [NameInMap("HaVips")]
        [Validation(Required=false)]
        public List<DescribeHaVipsResponseBodyHaVips> HaVips { get; set; }
        public class DescribeHaVipsResponseBodyHaVips : TeaModel {
            /// <summary>
            /// <para>The elastic IP addresses (EIPs) that are associated with the HAVIP.</para>
            /// </summary>
            [NameInMap("AssociatedEipAddresses")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses> AssociatedEipAddresses { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedEipAddresses : TeaModel {
                /// <summary>
                /// <para>The EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.XX.XX.40</para>
                /// </summary>
                [NameInMap("Eip")]
                [Validation(Required=false)]
                public string Eip { get; set; }

                /// <summary>
                /// <para>The ID of the EIP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-5p1wz****</para>
                /// </summary>
                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

            }

            /// <summary>
            /// <para>The information about instances that are associated with the HAVIP.</para>
            /// </summary>
            [NameInMap("AssociatedInstances")]
            [Validation(Required=false)]
            public List<DescribeHaVipsResponseBodyHaVipsAssociatedInstances> AssociatedInstances { get; set; }
            public class DescribeHaVipsResponseBodyHaVipsAssociatedInstances : TeaModel {
                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-05T07:09:28Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-51p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The type of the instance that is associated with the HAVIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EnsInstance: ENS instance</description></item>
                /// <item><description>NetworkInterface: elastic network interface (ENI)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnsInstance</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The private IP address of the instance that is associated with the HAVIP. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.9</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The association status of the HAVIP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Associating</description></item>
                /// <item><description>InUse</description></item>
                /// <item><description>Unassociating</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The time when the HAVIP was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-29T11:17:38Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the HAVIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-guiyang-14</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the HAVIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>havip-52y28****</para>
            /// </summary>
            [NameInMap("HaVipId")]
            [Validation(Required=false)]
            public string HaVipId { get; set; }

            /// <summary>
            /// <para>The IP address of the HAVIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.5</para>
            /// </summary>
            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <para>The name of the HAVIP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5wtkyrk****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The status of the HAVIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating</description></item>
            /// <item><description>Available</description></item>
            /// <item><description>InUse</description></item>
            /// <item><description>Deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-5yc8d****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAE90880-4970-4D81-A534-A6C0F3631F74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
