// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCacheAnalysisJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup file. You can call the <a href="https://help.aliyun.com/document_detail/473823.html">DescribeBackups</a> operation to obtain the backup file ID.</para>
        /// <list type="bullet">
        /// <item><description>To specify multiple backup file IDs, separate them with commas (,), such as <c>12345,67890</c>.</description></item>
        /// <item><description>If you do not specify this parameter, the system automatically performs a backup and runs cache analysis on the backup file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Redis instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp18ff4a195d****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data node in the instance. Specify this parameter to query monitoring information of a specific node.</para>
        /// <remarks>
        /// <para>If you specify the BackupSetId parameter, this parameter is ignored. You can call the <a href="https://help.aliyun.com/document_detail/473786.html">DescribeLogicInstanceTopology</a> operation to query node IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-x****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The delimiters used to identify key prefixes. You do not need to specify this parameter if the default delimiters <c>:;,_-+@=|#</c> are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&amp;</para>
        /// </summary>
        [NameInMap("Separators")]
        [Validation(Required=false)]
        public string Separators { get; set; }

    }

}
