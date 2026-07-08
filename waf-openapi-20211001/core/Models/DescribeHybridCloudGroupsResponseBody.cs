// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of hybrid cloud node groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeHybridCloudGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The back-to-origin mark of the protection cluster. The value is in the <b>{CarrierTag}-{ContinentTag}-{CityTag}-{Identifier}</b> format. The identifier is optional.</para>
            /// <remarks>
            /// <para>For a list of valid values, see Additional information about response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-asiapacific-beijing-56477821</para>
            /// </summary>
            [NameInMap("BackSourceMark")]
            [Validation(Required=false)]
            public string BackSourceMark { get; set; }

            /// <summary>
            /// <para>The continent code of the protection cluster.</para>
            /// <remarks>
            /// <para>For a list of valid codes, see Additional information about response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>410</para>
            /// </summary>
            [NameInMap("ContinentsValue")]
            [Validation(Required=false)]
            public int? ContinentsValue { get; set; }

            /// <summary>
            /// <para>The ID of the hybrid cloud node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the hybrid cloud node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StorageGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the hybrid cloud node group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>protect</b>: protection node group.</para>
            /// </description></item>
            /// <item><description><para><b>control</b>: control node group.</para>
            /// </description></item>
            /// <item><description><para><b>storage</b>: storage node group.</para>
            /// </description></item>
            /// <item><description><para><b>controlStorage</b>: control and storage node group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>protect</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The IP address of the load balancer that is associated with the hybrid cloud node group.</para>
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
            /// <para>The carrier code of the protection cluster.</para>
            /// <remarks>
            /// <para>For a list of valid codes, see Additional information about response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OperatorValue")]
            [Validation(Required=false)]
            public int? OperatorValue { get; set; }

            /// <summary>
            /// <para>The ports that are used by the hybrid cloud cluster. Multiple ports are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80,9200,20018</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public string Ports { get; set; }

            /// <summary>
            /// <para>The city code of the protection cluster.</para>
            /// <remarks>
            /// <para>For a list of valid codes, see Additional information about response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionCodeValue")]
            [Validation(Required=false)]
            public int? RegionCodeValue { get; set; }

            /// <summary>
            /// <para>The description of the hybrid cloud node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>045660E7-C4C6-5CD7-8182-7B337D95ADF4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of hybrid cloud node groups returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>146</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
