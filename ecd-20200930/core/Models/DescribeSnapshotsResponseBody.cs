// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token for the next query. If the value is empty, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51592A88-0F2C-55E6-AD2C-2AD9C10D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The time when the snapshot was created. The time is displayed in UTC and follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-20T14:52:28Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Administrator</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was created. The time is displayed in UTC+0 in the <c>yyyy-mm-ddthh:mm:ssz</c> format in accordance with the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard.</para>
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
            /// <para>The ID of the cloud desktop to which the snapshot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-g03l3tlm8djoj****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The status of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <para>The status of the disk to which the snapshot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("DiskStatus")]
            [Validation(Required=false)]
            public string DiskStatus { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("JvsId")]
            [Validation(Required=false)]
            public string JvsId { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The creation progress of the snapshot. Unit: percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The remaining time required to create the snapshot. Unit: seconds.</para>
            /// <remarks>
            /// <para>If <c>Status</c> is <c>PROGRESSING</c>, the value of <c>RemainTime</c> is <c>-1</c>, which indicates that the remaining time is being calculated.</para>
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
            /// <para>Data cloud disk backup</para>
            /// </summary>
            [NameInMap("RestorePointName")]
            [Validation(Required=false)]
            public string RestorePointName { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot.</para>
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
            /// <para>The snapshot type.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("SourceDiskType")]
            [Validation(Required=false)]
            public string SourceDiskType { get; set; }

            /// <summary>
            /// <para>The snapshot status.</para>
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
            /// <para>The ID of the KMS key used when disk encryption is enabled. You can obtain the key ID by calling the <a href="https://help.aliyun.com/document_detail/28951.html">ListKeys</a> operation.</para>
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
