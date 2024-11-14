// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The node groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeHybridCloudGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The back-to-origin mark of the protected cluster. The value is in the {ISP name}-{Continent name}-{City name}-{Back-to-origin identifier} format. The back-to-origin identifier is optional.</para>
            /// <remarks>
            /// <para> For more information about ISP names, continent names, city names, and back-to-origin identifiers, see the following sections.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-asiapacific-beijing-12345678</para>
            /// </summary>
            [NameInMap("BackSourceMark")]
            [Validation(Required=false)]
            public string BackSourceMark { get; set; }

            /// <summary>
            /// <para>The continent code of the protected cluster.</para>
            /// <remarks>
            /// <para> For more information about continent codes, see Continent codes in this topic.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>410</para>
            /// </summary>
            [NameInMap("ContinentsValue")]
            [Validation(Required=false)]
            public int? ContinentsValue { get; set; }

            /// <summary>
            /// <para>The ID of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StorageGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the node group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>protect</b></description></item>
            /// <item><description><b>control</b></description></item>
            /// <item><description><b>storage</b></description></item>
            /// <item><description><b>controlStorage</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>protect</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The IP address of the server used for load balancing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("LoadBalanceIp")]
            [Validation(Required=false)]
            public string LoadBalanceIp { get; set; }

            /// <summary>
            /// <para>The ID of the protection node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1312</para>
            /// </summary>
            [NameInMap("LocationId")]
            [Validation(Required=false)]
            public long? LocationId { get; set; }

            /// <summary>
            /// <para>The ISP code of the protected cluster.</para>
            /// <remarks>
            /// <para> For more information about ISP codes, see ISP codes in this topic.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OperatorValue")]
            [Validation(Required=false)]
            public int? OperatorValue { get; set; }

            /// <summary>
            /// <para>The port that is used by the hybrid cloud cluster. The value of this parameter is a string. If multiple ports are returned, the value is in the <b>port1,port2,port3</b> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,9200,20018</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }

            /// <summary>
            /// <para>The city code of the protected cluster.</para>
            /// <remarks>
            /// <para> For more information about city codes, see City codes in this topic.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionCodeValue")]
            [Validation(Required=false)]
            public int? RegionCodeValue { get; set; }

            /// <summary>
            /// <para>The description of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>045660E7-C4C6-5CD7-8182-7B337D95****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
