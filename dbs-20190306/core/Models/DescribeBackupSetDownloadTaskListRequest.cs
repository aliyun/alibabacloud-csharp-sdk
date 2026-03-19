// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupSetDownloadTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the value of this parameter.</para>
        /// <remarks>
        /// <para>You must specify either <b>BackupPlanId</b> or <b>BackupSetDownloadTaskId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dbsqhnuhyw3****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the backup set download task.</para>
        /// <list type="bullet">
        /// <item><description><para>For a full backup, call the <a href="https://help.aliyun.com/document_detail/2869842.html">CreateFullBackupSetDownload</a> operation to obtain the value of this parameter.</para>
        /// </description></item>
        /// <item><description><para>For an incremental backup, call the <a href="https://help.aliyun.com/document_detail/2869843.html">CreateIncrementBackupSetDownload</a> operation to obtain the value of this parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>urxgrxt7****</para>
        /// </summary>
        [NameInMap("BackupSetDownloadTaskId")]
        [Validation(Required=false)]
        public string BackupSetDownloadTaskId { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. This prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzXXXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a non-negative integer that does not exceed the maximum value of the integer type. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 30, 50, and 100.</para>
        /// <remarks>
        /// <para>The default value is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
