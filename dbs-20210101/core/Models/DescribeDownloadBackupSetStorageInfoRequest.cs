// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeDownloadBackupSetStorageInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30****</para>
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
        /// <para>The validity period of the URL that is used as the download destination. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Default value: 7200. This means that the URL is valid for 2 hours by default.</description></item>
        /// <item><description>Valid values: 300 to 86400. Unit: seconds. This means that you can specify a validity period in the range of 5 minutes to 1 day.</description></item>
        /// <item><description>Before you specify this parameter, convert the validity period to seconds. For example, if you want to set the validity period of the URL to 5 minutes, enter 300.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>The <b>BackupSetId</b> parameter is required if you specify the <b>InstanceName</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6qqf569n435****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// <para>The download task ID.</para>
        /// <list type="bullet">
        /// <item><description>The <b>BackupSetId</b> and <b>InstanceName</b> parameters are required if you do not specify the <b>TaskId</b> parameter.</description></item>
        /// <item><description>To view the download task ID, go to the instance details page in the console and click <b>Backup and Restoration</b> in the left-side navigation pane. On the <b>Backup Download</b> tab, view the task ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dt-s0ugzak9****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
