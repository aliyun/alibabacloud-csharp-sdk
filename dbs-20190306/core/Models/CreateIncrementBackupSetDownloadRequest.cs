// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateIncrementBackupSetDownloadRequest : TeaModel {
        /// <summary>
        /// <para>The format in which the incremental backup set is downloaded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Native</b></description></item>
        /// <item><description><b>SQL</b></description></item>
        /// <item><description><b>CSV</b></description></item>
        /// <item><description><b>JSON</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: Native.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Native</para>
        /// </summary>
        [NameInMap("BackupSetDataFormat")]
        [Validation(Required=false)]
        public string BackupSetDataFormat { get; set; }

        /// <summary>
        /// <para>The ID of the incremental backup task. To obtain the task ID, you can call the <a href="https://help.aliyun.com/document_detail/2869833.html">DescribeIncrementBackupList</a> operation and view the value of the <b>BackupSetJobId</b> parameter in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01e****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The ID of the incremental backup set. To obtain the backup set ID, you can call the <a href="https://help.aliyun.com/document_detail/2869833.html">DescribeIncrementBackupList</a> operation and view the value of the <b>BackupSetId</b> parameter in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("BackupSetName")]
        [Validation(Required=false)]
        public string BackupSetName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
