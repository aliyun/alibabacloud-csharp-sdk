// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateRestoreJobRequest : TeaModel {
        /// <summary>
        /// <para>The directory in which the files included in the restoration task are located. This parameter is specified when you create the anti-ransomware policy. The value is a directory that requires protection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;root&quot;]</para>
        /// </summary>
        [NameInMap("Includes")]
        [Validation(Required=false)]
        public string Includes { get; set; }

        /// <summary>
        /// <para>The hash value of the snapshot.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d4b399edaad94b038e8f91873f19e3eae010ca30798fc36db3a164dd343f****</para>
        /// </summary>
        [NameInMap("SnapshotHash")]
        [Validation(Required=false)]
        public string SnapshotHash { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot that you want to use for restoration.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-00023dhaatxp18mh****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The version of the backup data.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165570544****</para>
        /// </summary>
        [NameInMap("SnapshotVersion")]
        [Validation(Required=false)]
        public string SnapshotVersion { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backup snapshots for Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>File</b>: backup snapshots for on-premises servers</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The path to which you want to restore data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/testfls</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The UUID of the server whose data you want to restore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-ecs-4e876cb0-09f7-43b8-82ef-4bc7a93769b5</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault that is used in the restoration task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0002n12wokck2q0x****</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
