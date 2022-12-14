/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateDownloadRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set. You can call the [DescribeBackups](~~26273~~) operation to obtain the ID of the backup set.
        /// 
        /// >  This parameter is required if the BakSetType parameter is set to full.
        /// </summary>
        [NameInMap("BakSetId")]
        [Validation(Required=false)]
        public string BakSetId { get; set; }

        /// <summary>
        /// The size of the full backup set. You can call the [DescribeBackups](~~26273~~) operation to query the size of the full backup set. Unit: bytes.
        /// </summary>
        [NameInMap("BakSetSize")]
        [Validation(Required=false)]
        public string BakSetSize { get; set; }

        /// <summary>
        /// The type of the download task. Valid values:
        /// 
        /// *   **full**: downloads a full backup set.
        /// *   **pitr**: downloads a backup set at a specific point in time.
        /// </summary>
        [NameInMap("BakSetType")]
        [Validation(Required=false)]
        public string BakSetType { get; set; }

        /// <summary>
        /// The point in time at which the backup set is downloaded. The UNIX timestamp of the LONG type. Unit: milliseconds.
        /// 
        /// >  This parameter is required if the BakSetType parameter is set to pitr.
        /// </summary>
        [NameInMap("DownloadPointInTime")]
        [Validation(Required=false)]
        public string DownloadPointInTime { get; set; }

        /// <summary>
        /// The destination format to which the downloaded backup set is converted. Valid values:
        /// 
        /// *   **csv**
        /// *   **SQL**
        /// *   **Parquet**
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides. You can call the [DescribeDBInstanceAttribute](~~26231~~) operation to query the region ID of the instance.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// The name of the OSS bucket that is used to store the backup set.
        /// 
        /// *   This parameter is required if the TargetType parameter is set to OSS.
        /// *   Make sure that your account has the **AliyunDBSDefaultRole** permission. For more information, see [Use RAM for resource authorization](~~26307~~). You can also grant permissions based on the operation instructions in the RAM console.
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// The region in which the OSS bucket resides.
        /// 
        /// >  This parameter is required if the TargetType parameter is set to OSS.
        /// </summary>
        [NameInMap("TargetOssRegion")]
        [Validation(Required=false)]
        public string TargetOssRegion { get; set; }

        /// <summary>
        /// The destination path of the downloaded data.
        /// 
        /// >  This parameter is required if the TargetType parameter is set to OSS.
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// The type of the method in which the backup set is downloaded. Valid values:
        /// 
        /// *   **OSS**
        /// *   **URL**
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
