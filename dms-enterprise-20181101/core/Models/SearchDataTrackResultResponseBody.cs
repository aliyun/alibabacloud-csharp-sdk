// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDataTrackResultResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TrackResult")]
        [Validation(Required=false)]
        public SearchDataTrackResultResponseBodyTrackResult TrackResult { get; set; }
        public class SearchDataTrackResultResponseBodyTrackResult : TeaModel {
            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultEventList> EventList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultEventList : TeaModel {
                [NameInMap("DataAfter")]
                [Validation(Required=false)]
                public List<string> DataAfter { get; set; }

                [NameInMap("DataBefore")]
                [Validation(Required=false)]
                public List<string> DataBefore { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public long? EventId { get; set; }

                [NameInMap("EventLength")]
                [Validation(Required=false)]
                public long? EventLength { get; set; }

                [NameInMap("EventTimestamp")]
                [Validation(Required=false)]
                public string EventTimestamp { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("RollSQL")]
                [Validation(Required=false)]
                public string RollSQL { get; set; }

            }

            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<SearchDataTrackResultResponseBodyTrackResultTableInfoList> TableInfoList { get; set; }
            public class SearchDataTrackResultResponseBodyTrackResultTableInfoList : TeaModel {
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns> Columns { get; set; }
                public class SearchDataTrackResultResponseBodyTrackResultTableInfoListColumns : TeaModel {
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    [NameInMap("ColumnPosition")]
                    [Validation(Required=false)]
                    public int? ColumnPosition { get; set; }

                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    [NameInMap("Fictive")]
                    [Validation(Required=false)]
                    public bool? Fictive { get; set; }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
