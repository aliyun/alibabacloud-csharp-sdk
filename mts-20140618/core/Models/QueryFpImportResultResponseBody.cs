// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpImportResultResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public QueryFpImportResultResponseBodyPageInfo PageInfo { get; set; }
        public class QueryFpImportResultResponseBodyPageInfo : TeaModel {
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("FpResultLogInfoList")]
        [Validation(Required=false)]
        public QueryFpImportResultResponseBodyFpResultLogInfoList FpResultLogInfoList { get; set; }
        public class QueryFpImportResultResponseBodyFpResultLogInfoList : TeaModel {
            [NameInMap("FpResultLogInfo")]
            [Validation(Required=false)]
            public List<QueryFpImportResultResponseBodyFpResultLogInfoListFpResultLogInfo> FpResultLogInfo { get; set; }
            public class QueryFpImportResultResponseBodyFpResultLogInfoListFpResultLogInfo : TeaModel {
                public long? LogStartTime { get; set; }
                public string LogPath { get; set; }
                public long? CreateTime { get; set; }
                public long? LogSize { get; set; }
                public string LogName { get; set; }
                public long? LogEndTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LogCount")]
        [Validation(Required=false)]
        public long? LogCount { get; set; }

    }

}
