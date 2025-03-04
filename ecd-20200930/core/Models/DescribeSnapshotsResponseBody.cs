// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>If the NextToken parameter is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51592A88-0F2C-55E6-AD2C-2AD9C10D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the queried snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The point in time at which the snapshot was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The user who creates the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Administrator</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was deleted. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("DeletionTime")]
            [Validation(Required=false)]
            public string DeletionTime { get; set; }

            /// <summary>
            /// <para>The description of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer to which the snapshot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-g03l3tlm8djoj****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The status of the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Stopped</description></item>
            /// <item><description>Starting</description></item>
            /// <item><description>Rebuilding</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Stopping</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>Deleted</description></item>
            /// <item><description>Pending</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The progress of creating the snapshot. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>HDX: High-definition Experience (HDX) protocol</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ASP: in-house Adaptive Streaming Protocol (ASP)</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The remaining time that is required to complete the snapshot creation. Unit: seconds.</para>
            /// <remarks>
            /// <para> When the <c>Status</c> value is <c>PROGRESSING</c>, the <c>RemainTime</c> value is <c>-1</c>. A value of -1 indicates that the system is calculating the remaining time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("RemainTime")]
            [Validation(Required=false)]
            public int? RemainTime { get; set; }

            /// <summary>
            /// <para>The ID of the restore point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rp-btgmaa20wkcju****</para>
            /// </summary>
            [NameInMap("RestorePointId")]
            [Validation(Required=false)]
            public string RestorePointId { get; set; }

            /// <summary>
            /// <para>The name of the restore point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataDiskBackup</para>
            /// </summary>
            [NameInMap("RestorePointName")]
            [Validation(Required=false)]
            public string RestorePointName { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-2zeipxmnhej803x7****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The name of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSnapshotName</para>
            /// </summary>
            [NameInMap("SnapshotName")]
            [Validation(Required=false)]
            public string SnapshotName { get; set; }

            /// <summary>
            /// <para>The type of the snapshot.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AUTO: automatic snapshot</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>USER: manual snapshot</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("SnapshotType")]
            [Validation(Required=false)]
            public string SnapshotType { get; set; }

            /// <summary>
            /// <para>The capacity of the source disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("SourceDiskSize")]
            [Validation(Required=false)]
            public string SourceDiskSize { get; set; }

            /// <summary>
            /// <para>The type of the source disk.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SYSTEM: system disk</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>DATA: data disk</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The status of the snapshot.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PROGRESSING: The snapshot is being created.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>FAILED: The snapshot fails to be created.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>ACCOMPLISHED: The snapshot is created.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACCOMPLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether disk encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that is used when disk encryption is enabled. You can call the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation to query the list of KMS keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddfa1d4****</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

    }

}
