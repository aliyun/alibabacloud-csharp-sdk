// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyInstanceCrossBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the cross-region backup feature on the instance. This parameter specifies whether you can back up data and logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the feature.</description></item>
        /// <item><description><b>1:</b> enables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Before you enable the cross-region backup feature, you must configure the CrossBackupRegion parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackupEnabled")]
        [Validation(Required=false)]
        public string BackupEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the cross-region backup files of the instance are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("CrossBackupRegion")]
        [Validation(Required=false)]
        public string CrossBackupRegion { get; set; }

        /// <summary>
        /// <para>The policy that is used to save the cross-region backup files of the instance. Set the value to <b>1</b>. The value 1 specifies that all cross-region backup files are saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cross-region log backup feature on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the feature.</description></item>
        /// <item><description><b>1:</b> enables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can enable the cross-region log backup feature only when the cross-region backup feature is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogBackupEnabled")]
        [Validation(Required=false)]
        public string LogBackupEnabled { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The policy that is used to retain the cross-region backup files of the instance. Set the value to 1. The value <b>1</b> specifies that the cross-region backup files of the instance are retained based on the specified retention period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetentType")]
        [Validation(Required=false)]
        public int? RetentType { get; set; }

        /// <summary>
        /// <para>The number of days for which the cross-region backup files of the instance are retained. Valid values: <b>7 to 1825</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
