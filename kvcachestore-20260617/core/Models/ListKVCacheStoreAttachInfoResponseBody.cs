// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAttachInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attachment information.</para>
        /// </summary>
        [NameInMap("AttachInfos")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAttachInfoResponseBodyAttachInfos> AttachInfos { get; set; }
        public class ListKVCacheStoreAttachInfoResponseBodyAttachInfos : TeaModel {
            /// <summary>
            /// <para>The time of the last attachment. The time follows the ISO 8601 standard. If the instance is not attached, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-20T08:30:00Z</para>
            /// </summary>
            [NameInMap("AttachedAt")]
            [Validation(Required=false)]
            public string AttachedAt { get; set; }

            /// <summary>
            /// <para>The capacity of the file system. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The serial number (SN) of the NVMe channel disk. This value is returned only when protocol is set to nvme and the channel is bound in the current round. If other protocols are used or the channel is not bound, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvaaaaaaaaaaaaaaaa</para>
            /// </summary>
            [NameInMap("ControlSn")]
            [Validation(Required=false)]
            public string ControlSn { get; set; }

            /// <summary>
            /// <para>The ID of the compute resource, such as the ECS instance ID or the Lingjun compute node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-hdsagtg61h2hf21</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>KVCacheStore KvcsId</para>
            /// 
            /// <b>Example:</b>
            /// <para>kvcs-xxxxx</para>
            /// </summary>
            [NameInMap("KvcsId")]
            [Validation(Required=false)]
            public string KvcsId { get; set; }

            /// <summary>
            /// <para>The ID of the file system-level mount point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-xxxxx</para>
            /// </summary>
            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

            /// <summary>
            /// <para>The NGUID of the KVCacheStore data disk. This value is returned only when protocol is set to nvme and the NGUID is generated for the instance. If other protocols are used or the NGUID is missing, the value is null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000-0000-0000-0000-000000000001</para>
            /// </summary>
            [NameInMap("Nguid")]
            [Validation(Required=false)]
            public string Nguid { get; set; }

            /// <summary>
            /// <para>The access channel protocol of the instance. Valid values: vsc (VSC channel) and nvme (TDC NVMe channel).</para>
            /// 
            /// <b>Example:</b>
            /// <para>nvme</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The region where the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The attachment status. Valid values: Attaching, Attached, and Detaching. After an instance is detached, the record is deleted and not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance type. Valid value: kvcs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>preview</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the compute-side VSC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-001</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <para>The zone where the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token. It is used to query the next batch of data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3NUkN7qf+fcWj7joK8M6tU</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. The request ID is returned regardless of whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B127704C-ECB1-5B0A-AA9C-8F394A6F179F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
