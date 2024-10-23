// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1ub9grke1****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried resource groups.</para>
        /// </summary>
        [NameInMap("GroupsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourceGroupResponseBodyGroupsInfo> GroupsInfo { get; set; }
        public class DescribeDBResourceGroupResponseBodyGroupsInfo : TeaModel {
            /// <summary>
            /// <para>The time when the resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFAULT</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The query execution mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>interactive</b></description></item>
            /// <item><description><b>batch</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/189502.html">Query execution modes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>interactive</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The database accounts that are associated with the resource group.</para>
            /// </summary>
            [NameInMap("GroupUserList")]
            [Validation(Required=false)]
            public List<string> GroupUserList { get; set; }

            /// <summary>
            /// <para>The database accounts that are associated with the resource group. Multiple database accounts are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb,testc</para>
            /// </summary>
            [NameInMap("GroupUsers")]
            [Validation(Required=false)]
            public string GroupUsers { get; set; }

            /// <summary>
            /// <para>The number of nodes. Each node provides 16 cores and 64 GB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The time when the resource group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
