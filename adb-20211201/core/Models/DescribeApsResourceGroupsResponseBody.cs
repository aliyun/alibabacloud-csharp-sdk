// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeApsResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried resource groups.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApsResourceGroupsResponseBodyData Data { get; set; }
        public class DescribeApsResourceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried resource groups.</para>
            /// </summary>
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeApsResourceGroupsResponseBodyDataResourceGroups> ResourceGroups { get; set; }
            public class DescribeApsResourceGroupsResponseBodyDataResourceGroups : TeaModel {
                /// <summary>
                /// <para>Indicates whether the resource group is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("CuOptions")]
                [Validation(Required=false)]
                public List<long?> CuOptions { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the resource group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Interactive</b></description></item>
                /// <item><description><b>Job</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/428610.html">Resource groups</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Job</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>The amount of remaining computing resources. Unit: ACUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("LeftComputeResource")]
                [Validation(Required=false)]
                public int? LeftComputeResource { get; set; }

                /// <summary>
                /// <para>The maximum amount of reserved computing resources. Unit: ACUs.</para>
                /// <list type="bullet">
                /// <item><description>If the value of GroupType is <b>Interactive</b>, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 16 ACUs.</description></item>
                /// <item><description>If the value of GroupType is <b>Job</b>, the amount of reserved computing resources that are not allocated in the cluster is returned in increments of 8 ACUs.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("MaxComputeResource")]
                [Validation(Required=false)]
                public int? MaxComputeResource { get; set; }

                /// <summary>
                /// <para>The minimum amount of reserved computing resources. Unit: ACUs.</para>
                /// <list type="bullet">
                /// <item><description>If the value of GroupType is <b>Interactive</b>, 16 is returned.</description></item>
                /// <item><description>If the value of GroupType is <b>Job</b>, 0 is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinComputeResource")]
                [Validation(Required=false)]
                public int? MinComputeResource { get; set; }

            }

            /// <summary>
            /// <para>The step size of resources. Unit: AnalyticDB compute units (ACUs).</para>
            /// <list type="bullet">
            /// <item><description>If the value of GroupType is <b>Interactive</b>, 16 is returned.</description></item>
            /// <item><description>If the value of GroupType is <b>Job</b>, 8 is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Step")]
            [Validation(Required=false)]
            public long? Step { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, a success message is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FC370D7-1D4C-5A8E-805E-F73366382C66</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
