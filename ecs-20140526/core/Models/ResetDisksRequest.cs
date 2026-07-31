// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResetDisksRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud disks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ResetDisksRequestDisk> Disk { get; set; }
        public class ResetDisksRequestDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud disk to be rolled back. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-j6cf7l0ewidb78lq****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The snapshot ID that corresponds to the specified cloud disk in the instance snapshot. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-j6cdofbycydvg7ey****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run without actually rolling back the cloud disks. The system checks whether required parameters are specified, whether the request format is valid, and whether resource status constraints are met. If the check fails, the corresponding error message is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description>false: performs a dry run and sends the request. If the check succeeds, the cloud disk rollback operation is initiated.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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

    }

}
