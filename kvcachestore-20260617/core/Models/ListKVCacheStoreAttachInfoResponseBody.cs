// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAttachInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of mount information.</para>
        /// </summary>
        [NameInMap("AttachInfos")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAttachInfoResponseBodyAttachInfos> AttachInfos { get; set; }
        public class ListKVCacheStoreAttachInfoResponseBodyAttachInfos : TeaModel {
            /// <summary>
            /// <para>The time of the most recent attach operation, in ISO 8601 format. The value is null if the instance has not been attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-20T08:30:00Z</para>
            /// </summary>
            [NameInMap("AttachedAt")]
            [Validation(Required=false)]
            public string AttachedAt { get; set; }

            /// <summary>
            /// <para>The file system capacity, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

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
            /// <para>The mount point ID at the file system level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mp-xxxxx</para>
            /// </summary>
            [NameInMap("MountPointId")]
            [Validation(Required=false)]
            public string MountPointId { get; set; }

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
            /// <para>The attach status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Attaching: The instance is being mounted.</description></item>
            /// <item><description>Attached: The instance is mounted.</description></item>
            /// <item><description>Detaching: The instance is being unmounted.</description></item>
            /// </list>
            /// <para>After unmounting is complete, the record is deleted and not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ATTACHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>kvcs: KVCacheStore (CPFS).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preview</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The VSC ID on the compute side.</para>
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
        /// <para>The pagination token used to query the next batch of data.</para>
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
        /// <para>The request ID. A request ID is returned regardless of whether the call is successful.</para>
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
