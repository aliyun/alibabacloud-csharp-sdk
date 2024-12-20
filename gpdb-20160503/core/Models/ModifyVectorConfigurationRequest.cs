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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a region.</para>
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
        /// <para>Specifies whether to enable vector engine optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b></description></item>
        /// <item><description><b>disabled</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>We recommend that you <b>do not enable</b> vector engine optimization in mainstream analysis and real-time data warehousing scenarios.</description></item>
        /// <item><description>We recommend that you <b>enable</b> vector engine optimization in AI Generated Content (AIGC) and vector retrieval scenarios that require the vector analysis engine.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("VectorConfigurationStatus")]
        [Validation(Required=false)]
        public string VectorConfigurationStatus { get; set; }

    }

}
