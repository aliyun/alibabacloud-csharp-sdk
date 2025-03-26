// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListElasticNetworkInterfacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListElasticNetworkInterfacesResponseBodyContent Content { get; set; }
        public class ListElasticNetworkInterfacesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>lingjun Elastic Network Interface information list</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListElasticNetworkInterfacesResponseBodyContentData> Data { get; set; }
            public class ListElasticNetworkInterfacesResponseBodyContentData : TeaModel {
                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1601176751000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Lingjun Elastic Network Interface ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>leni-1234****</para>
                /// </summary>
                [NameInMap("ElasticNetworkInterfaceId")]
                [Validation(Required=false)]
                public string ElasticNetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>vswitch gateway address</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.****</para>
                /// </summary>
                [NameInMap("Gateway")]
                [Validation(Required=false)]
                public string Gateway { get; set; }

                /// <summary>
                /// <para>The time when the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640187007000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The IP address of the BE cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.13</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>mac address</para>
                /// 
                /// <b>Example:</b>
                /// <para>E0:01:A6:4A:6A:D0</para>
                /// </summary>
                [NameInMap("Mac")]
                [Validation(Required=false)]
                public string Mac { get; set; }

                /// <summary>
                /// <para>vswitch mask bits</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01-cn-uax37m1****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-f8z4wr1b41x3qsc9****</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>network interface controller type, the default type DEFAULT cannot be manually released</para>
                /// <para>Valid value:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM: custom type.</description></item>
                /// <item><description>DEFAULT: system type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6u8473r84e9****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-f8ziirfl9k25h2qn7****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC8C713A-A9F4-5984-A5E1-76496DF35153</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
