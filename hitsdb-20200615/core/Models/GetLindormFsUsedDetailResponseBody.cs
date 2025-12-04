// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormFsUsedDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why the access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The total storage space of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacity")]
        [Validation(Required=false)]
        public string FsCapacity { get; set; }

        /// <summary>
        /// <para>The cold storage space of the cluster. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacityCold")]
        [Validation(Required=false)]
        public string FsCapacityCold { get; set; }

        /// <summary>
        /// <para>The hot storage space of the cluster. Unit: bytes.</para>
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
        /// <para>The cold storage usage of the table data of the search engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The cold storage usage of the table data of the time series engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The cold storage usage of the table data of the wide table engine. Unit: bytes.</para>
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
        /// <para>The hot storage usage of the table data of the search engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The hot storage usage of the table data of the time series engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The hot storage usage of the table data of the wide table engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage usage of the search engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The storage usage of the time series engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The space usage of the wide table engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage usage of the table data of the wide table engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableData")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableData { get; set; }

        /// <summary>
        /// <para>The storage usage of the log data of the wide table engine. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableWAL")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableWAL { get; set; }

        /// <summary>
        /// <para>If the version of the underlying storage engine is 4.1.9 or later, the storage usage values returned for the LStorageUsageList parameter prevail. Storage details are returned based on the storage type.</para>
        /// </summary>
        [NameInMap("LStorageUsageList")]
        [Validation(Required=false)]
        public List<GetLindormFsUsedDetailResponseBodyLStorageUsageList> LStorageUsageList { get; set; }
        public class GetLindormFsUsedDetailResponseBodyLStorageUsageList : TeaModel {
            /// <summary>
            /// <para>The total storage capacity. Unit: bytes.</para>
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
            /// <item><description>StandardCloudStorage</description></item>
            /// <item><description>PerformanceCloudStorage</description></item>
            /// <item><description>CapacityCloudStorage</description></item>
            /// <item><description>LocalSsdStorage</description></item>
            /// <item><description>LocalHddStorage</description></item>
            /// <item><description>LocalEbsStorage</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StandardCloudStorage</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The storage usage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public string Used { get; set; }

            [NameInMap("UsedLindormColumn3")]
            [Validation(Required=false)]
            public string UsedLindormColumn3 { get; set; }

            [NameInMap("UsedLindormMessage3")]
            [Validation(Required=false)]
            public string UsedLindormMessage3 { get; set; }

            /// <summary>
            /// <para>The storage usage of the search engine. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSearch")]
            [Validation(Required=false)]
            public string UsedLindormSearch { get; set; }

            /// <summary>
            /// <para>The storage usage of the compute engine. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSpark")]
            [Validation(Required=false)]
            public string UsedLindormSpark { get; set; }

            /// <summary>
            /// <para>The storage usage of the wide table engine. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormTable")]
            [Validation(Required=false)]
            public string UsedLindormTable { get; set; }

            /// <summary>
            /// <para>The storage usage of the time series engine. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormTsdb")]
            [Validation(Required=false)]
            public string UsedLindormTsdb { get; set; }

            [NameInMap("UsedLindormVector3")]
            [Validation(Required=false)]
            public string UsedLindormVector3 { get; set; }

            /// <summary>
            /// <para>The storage usage of other resources, such as logs and recycle bins. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedOther")]
            [Validation(Required=false)]
            public string UsedOther { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Each request has a unique ID. You can use the request ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F23D50C-400C-592C-9486-9D1E10179065</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the return value is valid. Valid values: true and false. If a value of false is returned, you must provide the request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Valid")]
        [Validation(Required=false)]
        public string Valid { get; set; }

    }

}
