// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormFsUsedDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Details on why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The total storage capacity of the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacity")]
        [Validation(Required=false)]
        public string FsCapacity { get; set; }

        /// <summary>
        /// <para>The cold storage capacity of the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacityCold")]
        [Validation(Required=false)]
        public string FsCapacityCold { get; set; }

        /// <summary>
        /// <para>The hot storage capacity of the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85899345920</para>
        /// </summary>
        [NameInMap("FsCapacityHot")]
        [Validation(Required=false)]
        public string FsCapacityHot { get; set; }

        /// <summary>
        /// <para>The cold storage used by the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedCold")]
        [Validation(Required=false)]
        public string FsUsedCold { get; set; }

        /// <summary>
        /// <para>The cold storage space used by table data of the search engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The cold storage space used by table data of the time series engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The cold storage space used by table data of the wide-column engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedColdOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedColdOnLindormTable { get; set; }

        /// <summary>
        /// <para>The hot storage used by the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHot")]
        [Validation(Required=false)]
        public string FsUsedHot { get; set; }

        /// <summary>
        /// <para>The hot storage space used by table data of the search engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The hot storage space used by table data of the time series engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The hot storage space used by table data of the wide-column engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedHotOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedHotOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage space used by the search engine in the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormSearch")]
        [Validation(Required=false)]
        public string FsUsedOnLindormSearch { get; set; }

        /// <summary>
        /// <para>The storage space used by the time series engine in the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTSDB")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTSDB { get; set; }

        /// <summary>
        /// <para>The storage space used by the wide-column engine in the cluster, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTable")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTable { get; set; }

        /// <summary>
        /// <para>The storage space used by table data of the wide-column engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableData")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableData { get; set; }

        /// <summary>
        /// <para>The storage space used by log data of the wide-column engine, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33269</para>
        /// </summary>
        [NameInMap("FsUsedOnLindormTableWAL")]
        [Validation(Required=false)]
        public string FsUsedOnLindormTableWAL { get; set; }

        /// <summary>
        /// <para>For clusters that run storage engine v4.1.9 or later, this parameter provides authoritative storage details categorized by storage medium.</para>
        /// </summary>
        [NameInMap("LStorageUsageList")]
        [Validation(Required=false)]
        public List<GetLindormFsUsedDetailResponseBodyLStorageUsageList> LStorageUsageList { get; set; }
        public class GetLindormFsUsedDetailResponseBodyLStorageUsageList : TeaModel {
            /// <summary>
            /// <para>The total storage capacity for this storage medium, in bytes.</para>
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
            /// <item><description><para><c>StandardCloudStorage</c>: standard cloud storage.</para>
            /// </description></item>
            /// <item><description><para><c>PerformanceCloudStorage</c>: performance cloud storage.</para>
            /// </description></item>
            /// <item><description><para><c>CapacityCloudStorage</c>: capacity cloud storage.</para>
            /// </description></item>
            /// <item><description><para><c>LocalSsdStorage</c>: local SSD.</para>
            /// </description></item>
            /// <item><description><para><c>LocalHddStorage</c>: local HDD.</para>
            /// </description></item>
            /// <item><description><para><c>LocalEbsStorage</c>: local block storage.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>StandardCloudStorage</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The storage used on this storage medium, in bytes.</para>
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
            /// <para>The storage used by the search engine on this storage medium, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSearch")]
            [Validation(Required=false)]
            public string UsedLindormSearch { get; set; }

            /// <summary>
            /// <para>The storage used by the compute engine on this storage medium, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormSpark")]
            [Validation(Required=false)]
            public string UsedLindormSpark { get; set; }

            /// <summary>
            /// <para>The storage used by the wide-column engine on this storage medium, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedLindormTable")]
            [Validation(Required=false)]
            public string UsedLindormTable { get; set; }

            /// <summary>
            /// <para>The storage used by the time series engine on this storage medium, in bytes.</para>
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
            /// <para>The storage used by other components, such as logs and trash, on this storage medium, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33269</para>
            /// </summary>
            [NameInMap("UsedOther")]
            [Validation(Required=false)]
            public string UsedOther { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This unique identifier is generated by Alibaba Cloud for each request and is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F23D50C-400C-592C-9486-9D1E10179065</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the response is valid. A value of <c>false</c> indicates that an error occurred, and you must provide the request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Valid")]
        [Validation(Required=false)]
        public string Valid { get; set; }

    }

}
