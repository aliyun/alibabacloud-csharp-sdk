// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListUserBackupFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the full backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b-kwwvr7v8t7of********</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The description of the full backup file.</para>
        /// <remarks>
        /// <para>The system implements a fuzzy match based on the value of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BackupTest</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The URL from which you can download the full backup file that is stored as an object in an Object Storage Service (OSS) bucket. For more information about how to obtain the URL, see <a href="https://help.aliyun.com/document_detail/39607.html">Obtain the access URL after you upload objects</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b><b>.oss-ap-</b></b></b>**.aliyuncs.com/backup_qp.xb</para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call the DescribeDBInstanceAttribute operation to obtain the ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
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
        /// <para>The status of the full backup file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Importing</b>: The full backup file is being imported.</description></item>
        /// <item><description><b>Failed</b>: The full backup file fails to be imported.</description></item>
        /// <item><description><b>CheckSucccess</b>: The full backup file passes the check.</description></item>
        /// <item><description><b>BackupSuccess</b>: The full backup file is imported.</description></item>
        /// <item><description><b>Deleted</b>: The full backup file is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CheckSuccess</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag that is added to the full backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key1:value1</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
