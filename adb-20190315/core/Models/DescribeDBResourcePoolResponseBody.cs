// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBResourcePoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Details of the resource group.</para>
        /// </summary>
        [NameInMap("PoolsInfo")]
        [Validation(Required=false)]
        public List<DescribeDBResourcePoolResponseBodyPoolsInfo> PoolsInfo { get; set; }
        public class DescribeDBResourcePoolResponseBodyPoolsInfo : TeaModel {
            /// <summary>
            /// <para>The time when the resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// <remarks>
            /// <para> Each node consumes 16 cores and 64 GB memory.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFAULT</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// <para>The database accounts that are associated with the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testb,testc</para>
            /// </summary>
            [NameInMap("PoolUsers")]
            [Validation(Required=false)]
            public string PoolUsers { get; set; }

            /// <summary>
            /// <para>The mode in which SQL statements are executed.</para>
            /// <list type="bullet">
            /// <item><description><b>batch</b></description></item>
            /// <item><description><b>interactive</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information, see <a href="https://help.aliyun.com/document_detail/189502.html">Query execution modes</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>default_type</para>
            /// </summary>
            [NameInMap("QueryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            /// <summary>
            /// <para>The time when the resource group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-09 16:57:35.241</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
