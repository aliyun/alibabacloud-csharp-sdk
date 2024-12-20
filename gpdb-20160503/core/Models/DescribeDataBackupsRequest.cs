// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataBackupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set. If you specify BackupId, the details of the backup set are returned.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/210093.html">DescribeDataBackups</a> operation to query the information about all backup sets of an instance, including backup set IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>327329803</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Automated</description></item>
        /// <item><description>Manual</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all backup sets are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automated</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The state of the backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success</description></item>
        /// <item><description>Failed</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all backup sets are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DATA</b>: full backup.</description></item>
        /// <item><description><b>RESTOREPOI</b>: point-in-time recovery backup.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the backup sets of full backup are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-01T16:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1</para>
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
        /// <item><description>30</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-01T15:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
