// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The recording data that was collected for each interval.</para>
        /// </summary>
        [NameInMap("RecordUsageData")]
        [Validation(Required=false)]
        public DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageData RecordUsageData { get; set; }
        public class DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageDataDataModule> DataModule { get; set; }
            public class DescribeLiveDomainRecordUsageDataResponseBodyRecordUsageDataDataModule : TeaModel {
                /// <summary>
                /// <para>The number of peak channels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The main streaming domain. This parameter is returned if the value of the request parameter SplitBy contains <c>domain</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The recording length. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3560</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The time when recording started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The recording file type. This parameter is returned if the value of the request parameter SplitBy contains <c>record_fmt</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MP4</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B460F8B-993C-4F48-B98A-910811DEBFEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
