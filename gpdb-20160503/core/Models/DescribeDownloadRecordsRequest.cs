// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDownloadRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The download task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SQL_DIAGNOSE</c>: SQL diagnosis.</para>
        /// </description></item>
        /// <item><description><para><c>SLOW_SQL</c>: slow SQL query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLOW_SQL</para>
        /// </summary>
        [NameInMap("DownloadTaskType")]
        [Validation(Required=false)]
        public string DownloadTaskType { get; set; }

    }

}
