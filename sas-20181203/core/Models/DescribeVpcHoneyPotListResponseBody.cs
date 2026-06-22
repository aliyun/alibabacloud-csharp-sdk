// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVpcHoneyPotListResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeVpcHoneyPotListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FEC7F58-FCDA-415F-AE25-CD8BC0931DF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about cloud honeypot instances.</para>
        /// </summary>
        [NameInMap("VpcHoneyPotDTOList")]
        [Validation(Required=false)]
        public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList> VpcHoneyPotDTOList { get; set; }
        public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOList : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The time when the VPC was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The status of the Elastic Compute Service (ECS) instance that corresponds to the cloud honeypot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: being created</description></item>
            /// <item><description><b>Running</b>: running</description></item>
            /// <item><description><b>Starting</b>: starting</description></item>
            /// <item><description><b>Stopping</b>: stopping</description></item>
            /// <item><description><b>Stopped</b>: stopped</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("HoneyPotEcsInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotEcsInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI) that the cloud honeypot created in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0whwgg7bing8b80****</para>
            /// </summary>
            [NameInMap("HoneyPotEniInstanceId")]
            [Validation(Required=false)]
            public string HoneyPotEniInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC has cloud honeypot enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HoneyPotExistence")]
            [Validation(Required=false)]
            public bool? HoneyPotExistence { get; set; }

            /// <summary>
            /// <para>The status of the cloud honeypot instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: being created</description></item>
            /// <item><description><b>deleting</b>: being deleted</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
            /// <item><description><b>suspending</b>: being suspended</description></item>
            /// <item><description><b>on</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HoneyPotInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ENI used by the cloud honeypot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-p0w7gdcfvn20tvdul****</para>
            /// </summary>
            [NameInMap("HoneyPotVpcSwitchId")]
            [Validation(Required=false)]
            public string HoneyPotVpcSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the cloud honeypot instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w223apdl49sr5zv****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC in which the cloud honeypot instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-vpcname</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC in which the cloud honeypot instance resides.</para>
            /// <remarks>
            /// <para>For the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-2</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// <para>The status of the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: normal</description></item>
            /// <item><description><b>Pending</b>: being configured</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("VpcStatus")]
            [Validation(Required=false)]
            public string VpcStatus { get; set; }

            /// <summary>
            /// <para>The information about vSwitches in the VPC.</para>
            /// </summary>
            [NameInMap("VpcSwitchIdList")]
            [Validation(Required=false)]
            public List<DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList> VpcSwitchIdList { get; set; }
            public class DescribeVpcHoneyPotListResponseBodyVpcHoneyPotDTOListVpcSwitchIdList : TeaModel {
                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-p0wdnyv4wzp6jkuu4****</para>
                /// </summary>
                [NameInMap("VpcSwitchId")]
                [Validation(Required=false)]
                public string VpcSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc01</para>
                /// </summary>
                [NameInMap("VpcSwitchName")]
                [Validation(Required=false)]
                public string VpcSwitchName { get; set; }

                /// <summary>
                /// <para>The zone ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-2b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
