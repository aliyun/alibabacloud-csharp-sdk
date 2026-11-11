// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceDiagnosisSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query details about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
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
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>20</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role state of the node. It specifies whether a primary/secondary switchover occurs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: The node role is normal. No primary/secondary switchover occurs.</description></item>
        /// <item><description><b>reverse</b>: The node role is reversed. A primary/secondary switchover occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("RolePreferd")]
        [Validation(Required=false)]
        public string RolePreferd { get; set; }

        /// <summary>
        /// <para>The running state of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UP</b>: The node is running.</description></item>
        /// <item><description><b>DOWN</b>: The node is faulty.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the information about nodes in all running states is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UP</para>
        /// </summary>
        [NameInMap("StartStatus")]
        [Validation(Required=false)]
        public string StartStatus { get; set; }

        /// <summary>
        /// <para>The data synchronization state of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>synced</b>: The node data is synchronized.</description></item>
        /// <item><description><b>notSyncing</b>: The node data is not synchronized.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the information about nodes in all synchronization states is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>synced</para>
        /// </summary>
        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
