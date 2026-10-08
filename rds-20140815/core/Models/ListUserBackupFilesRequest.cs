// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListUserBackupFilesRequest : TeaModel {
        /// <summary>
        /// <para>The user backup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-kwwvr7v8t7of****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The comment of the user backup to query.</para>
        /// <remarks>
        /// <para>You can enter part of the comment for fuzzy matching.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BackupTest</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The OSS download URL of the user backup file. For information about how to obtain the OSS download URL of a user backup file, see <a href="https://help.aliyun.com/document_detail/39607.html">How do I obtain the URL of an uploaded object?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.oss-ap-</b></b>.aliyuncs.com/backup_qp.xb</para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call DescribeDBInstanceAttribute to query the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The status of the user backup file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Importing</b>: The backup is being imported.</description></item>
        /// <item><description><b>Failed</b>: The import failed.</description></item>
        /// <item><description><b>CheckSuccess</b>: The verification passed.</description></item>
        /// <item><description><b>BackupSuccess</b>: The import succeeded.</description></item>
        /// <item><description><b>Deleted</b>: The backup is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CheckSuccess</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag information used to query the user backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1:value1</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
