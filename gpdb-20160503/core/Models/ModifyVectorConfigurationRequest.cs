// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyVectorConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the vector engine optimization configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enables vector engine optimization.</description></item>
        /// <item><description><b>disabled</b>: Disables vector engine optimization.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For mainstream analytics, data warehouse, and real-time data warehouse scenarios, <b>do not enable</b> vector engine optimization.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For users who use the vector analysis engine for AIGC and vector retrieval scenarios, <b>enable</b> vector engine optimization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("VectorConfigurationStatus")]
        [Validation(Required=false)]
        public string VectorConfigurationStatus { get; set; }

    }

}
