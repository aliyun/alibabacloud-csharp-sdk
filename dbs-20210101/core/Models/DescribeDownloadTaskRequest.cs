// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set generated when you create a download task. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>216****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dds-example</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the Database Backup (DBS) data source. Specify the parameter in the format of <em>ds-${Instance ID}_${regionId}</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-rm-2ze8g2am97624****_cn-hangzhou</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify this parameter as a timestamp of the LONG type. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661941556000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1imnmcjxdz7****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The column based on which the entries are sorted. By default, the entries are sorted by the time when the download task was created. Set the value to <b>gmt_create</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmt_create</para>
        /// </summary>
        [NameInMap("OrderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: the ascending order.</description></item>
        /// <item><description><b>desc</b>: the descending order. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderDirect")]
        [Validation(Required=false)]
        public string OrderDirect { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides. You can call the <a href="https://help.aliyun.com/document_detail/26231.html">DescribeDBInstanceAttribute</a> operation to query the region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify this parameter as a timestamp of the LONG type. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661941554000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The state of the download task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Initializing</b>: The download task is being initialized.</description></item>
        /// <item><description><b>queueing</b>: The download task is queuing.</description></item>
        /// <item><description><b>running</b>: The download task is running.</description></item>
        /// <item><description><b>failed</b>: The download task fails.</description></item>
        /// <item><description><b>finished</b>: The download task is complete.</description></item>
        /// <item><description><b>expired</b>: The download task expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>queueing</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The type of the download task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>full</b>: downloads a full backup set.</description></item>
        /// <item><description><b>pitr</b>: downloads a backup set at a specific point in time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
