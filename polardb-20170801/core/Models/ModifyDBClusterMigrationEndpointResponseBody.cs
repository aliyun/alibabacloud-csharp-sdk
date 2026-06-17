// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterMigrationEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to view information about all clusters in the destination region, including the cluster ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-k2j1qqukj583di7n9</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F901FB05-8109-547F-A0B9-9C4FF7F4927A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21498490</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
