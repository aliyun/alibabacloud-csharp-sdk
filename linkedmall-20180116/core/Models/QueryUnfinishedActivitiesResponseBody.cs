// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUnfinishedActivitiesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("LmActivityModelExtList")]
        [Validation(Required=false)]
        public QueryUnfinishedActivitiesResponseBodyLmActivityModelExtList LmActivityModelExtList { get; set; }
        public class QueryUnfinishedActivitiesResponseBodyLmActivityModelExtList : TeaModel {
            [NameInMap("LmActivityModelV2Ext")]
            [Validation(Required=false)]
            public List<QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2Ext> LmActivityModelV2Ext { get; set; }
            public class QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2Ext : TeaModel {
                public string EndDate { get; set; }
                public string Description { get; set; }
                public string StartDate { get; set; }
                public long? LmActivityId { get; set; }
                public string BizId { get; set; }
                public string ActivityPicUrl { get; set; }
                public string Name { get; set; }
                public QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2ExtLmActivitySessionModels LmActivitySessionModels { get; set; }
                public class QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2ExtLmActivitySessionModels : TeaModel {
                    [NameInMap("LmActivitySessionModel")]
                    [Validation(Required=false)]
                    public List<QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2ExtLmActivitySessionModelsLmActivitySessionModel> LmActivitySessionModel { get; set; }
                    public class QueryUnfinishedActivitiesResponseBodyLmActivityModelExtListLmActivityModelV2ExtLmActivitySessionModelsLmActivitySessionModel : TeaModel {
                        [NameInMap("SubBizCode")]
                        [Validation(Required=false)]
                        public string SubBizCode { get; set; }

                        [NameInMap("EndDate")]
                        [Validation(Required=false)]
                        public string EndDate { get; set; }

                        [NameInMap("DisplayDate")]
                        [Validation(Required=false)]
                        public string DisplayDate { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("LmSessionId")]
                        [Validation(Required=false)]
                        public long? LmSessionId { get; set; }

                        [NameInMap("StartDate")]
                        [Validation(Required=false)]
                        public string StartDate { get; set; }

                        [NameInMap("BizId")]
                        [Validation(Required=false)]
                        public string BizId { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtInfo { get; set; }

                    }

                }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
