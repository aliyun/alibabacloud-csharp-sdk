// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormFsUsedDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The total storage capacity of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacity")]
        [Validation(Required=false)]
        public string FsCapacity { get; set; }

        /// <summary>
        /// <para>The cold storage capacity of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacityCold")]
        [Validation(Required=false)]
        public string FsCapacityCold { get; set; }

        /// <summary>
        /// <para>The hot storage capacity of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacityHot")]
        [Validation(Required=false)]
        public string FsCapacityHot { get; set; }

        /// <summary>
        /// <para>The cold storage usage of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedCold")]
        [Validation(Required=false)]
        public string FsUsedCold { get; set; }

        /// <summary>
        /// <para>The cold storage usage of table data in the search index DPI engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The cold storage usage of table data in the LindormTSDB engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The cold storage usage of table data in the LindormTable engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormTable { get; set; }

        /// <summary>
        /// <para>The hot storage usage of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHot")]
        [Validation(Required=false)]
        public string FsUsedHot { get; set; }

        /// <summary>
        /// <para>The hot storage usage of table data in the search index DPI engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The hot storage usage of table data in the LindormTSDB engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The hot storage usage of table data in the LindormTable engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage usage of the search index DPI engine in the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The storage usage of the LindormTSDB engine in the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The storage usage of the LindormTable engine in the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage usage of table data in the LindormTable engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableData")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableData { get; set; }

        /// <summary>
        /// <para>The storage usage of write-ahead log (wal) data in the LindormTable engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableWAL")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableWAL { get; set; }

        /// <summary>
        /// <para>For clusters with an underlying storage DPI engine version of 4.1.9 or later, this field is the authoritative source for storage details, categorized by storage medium categorization.</para>
        /// </summary>
        [NameInMap("LStorageUsageList")]
        [Validation(Required=false)]
        public List<GetLindormFsUsedDetailResponseBodyLStorageUsageList> LStorageUsageList { get; set; }
        public class GetLindormFsUsedDetailResponseBodyLStorageUsageList : TeaModel {
            /// <summary>
            /// <para>The total storage capacity for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85899345920</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <para>The storage type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>StandardCloudStorage: standard cloud storage.</description></item>
            /// <item><description>PerformanceCloudStorage: performance cloud storage.</description></item>
            /// <item><description>CapacityCloudStorage: capacity cloud storage.</description></item>
            /// <item><description>LocalSsdStorage: local SSD.</description></item>
            /// <item><description>LocalHddStorage: local HDD.</description></item>
            /// <item><description>LocalEbsStorage: local cloud storage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StandardCloudStorage</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public string Used { get; set; }

            /// <summary>
            /// <para>The column store engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>688935</para>
            /// </summary>
            [NameInMap("UsedLindormColumn3")]
            [Validation(Required=false)]
            public string UsedLindormColumn3 { get; set; }

            /// <summary>
            /// <para>The message engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UsedLindormMessage3")]
            [Validation(Required=false)]
            public string UsedLindormMessage3 { get; set; }

            /// <summary>
            /// <para>The search index DPI engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSearch")]
            [Validation(Required=false)]
            public string UsedLindormSearch { get; set; }

            /// <summary>
            /// <para>The compute engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSpark")]
            [Validation(Required=false)]
            public string UsedLindormSpark { get; set; }

            /// <summary>
            /// <para>The LindormTable engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormTable")]
            [Validation(Required=false)]
            public string UsedLindormTable { get; set; }

            /// <summary>
            /// <para>The LindormTSDB engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormTsdb")]
            [Validation(Required=false)]
            public string UsedLindormTsdb { get; set; }

            /// <summary>
            /// <para>The vector engine storage usage for the storage medium type. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>595054865855</para>
            /// </summary>
            [NameInMap("UsedLindormVector3")]
            [Validation(Required=false)]
            public string UsedLindormVector3 { get; set; }

            /// <summary>
            /// <para>The storage usage for other purposes under the storage medium type, such as logs and the recycle bin. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedOther")]
            [Validation(Required=false)]
            public string UsedOther { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F23D50C-400C-592C-9486-9D1E10179065</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the return value is valid. true indicates that the value is valid. false indicates that an exception occurred. Provide the request ID to troubleshoot the issue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Valid")]
        [Validation(Required=false)]
        public string Valid { get; set; }

    }

}
