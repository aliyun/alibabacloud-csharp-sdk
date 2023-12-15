// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCityMapCameraStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCityMapCameraStatisticsResponseBodyData> Data { get; set; }
        public class ListCityMapCameraStatisticsResponseBodyData : TeaModel {
            [NameInMap("AdultValue")]
            [Validation(Required=false)]
            public string AdultValue { get; set; }

            [NameInMap("ChildValue")]
            [Validation(Required=false)]
            public string ChildValue { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("ManValue")]
            [Validation(Required=false)]
            public string ManValue { get; set; }

            [NameInMap("MotorValue")]
            [Validation(Required=false)]
            public string MotorValue { get; set; }

            [NameInMap("OldValue")]
            [Validation(Required=false)]
            public string OldValue { get; set; }

            [NameInMap("StatisticTime")]
            [Validation(Required=false)]
            public string StatisticTime { get; set; }

            [NameInMap("WomanValue")]
            [Validation(Required=false)]
            public string WomanValue { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
