// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateDBResourcePoolRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL clusters in a specific region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes. The default value is 0.</para>
        /// <list type="bullet">
        /// <item><description><para>A single node provides 16 cores and 64 GB of memory.</para>
        /// </description></item>
        /// <item><description><para>The total resources, calculated as (Number of nodes × 16 cores and 64 GB of memory), cannot exceed the total resources of the cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public int? NodeNum { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <list type="bullet">
        /// <item><description><para>The name can be up to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It must start with a digit, an uppercase letter, or a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>It can contain digits, uppercase letters, lowercase letters, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PoolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

        /// <summary>
        /// <para>The execution mode of the SQL query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>batch</b>: batch processing mode.</para>
        /// </description></item>
        /// <item><description><para><b>interactive</b> (default): interactive mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/189502.html">Query execution modes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>interactive</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
