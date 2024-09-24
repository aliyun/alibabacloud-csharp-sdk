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
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FEC7F58-FCDA-415F-AE25-CD8BC0931DF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the honeypots.</para>
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
            /// <para>The time at which the VPC was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607365213000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The status of the server on which the honeypot is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: The server is being created.</description></item>
            /// <item><description><b>Running</b>: The server is running.</description></item>
            /// <item><description><b>Starting</b>: The server is being started.</description></item>
            /// <item><description><b>Stopping</b>: The server is being stopped.</description></item>
            /// <item><description><b>Stopped</b>: The server is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("HoneyPotEcsInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotEcsInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI) used by the honeypot in the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-p0whwgg7bing8b80****</para>
            /// </summary>
            [NameInMap("HoneyPotEniInstanceId")]
            [Validation(Required=false)]
            public string HoneyPotEniInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud honeypot feature is enabled for the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HoneyPotExistence")]
            [Validation(Required=false)]
            public bool? HoneyPotExistence { get; set; }

            /// <summary>
            /// <para>The status of the honeypot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: The honeypot is being created.</description></item>
            /// <item><description><b>deleting</b>: The honeypot is being deleted.</description></item>
            /// <item><description><b>off</b>: The honeypot is disabled.</description></item>
            /// <item><description><b>suspending</b>: The honeypot is suspended.</description></item>
            /// <item><description><b>on</b>: The honeypot is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HoneyPotInstanceStatus")]
            [Validation(Required=false)]
            public string HoneyPotInstanceStatus { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the ENI used by the honeypot is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-p0w7gdcfvn20tvdul****</para>
            /// </summary>
            [NameInMap("HoneyPotVpcSwitchId")]
            [Validation(Required=false)]
            public string HoneyPotVpcSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-p0w223apdl49sr5zv****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc-vpcname</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC.</para>
            /// <remarks>
            /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
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
            /// <item><description><b>Available</b>: The VPC is normal and available.</description></item>
            /// <item><description><b>Pending</b>: The VPC is being configured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("VpcStatus")]
            [Validation(Required=false)]
            public string VpcStatus { get; set; }

            /// <summary>
            /// <para>An array that consists of the vSwitches in the VPC.</para>
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
