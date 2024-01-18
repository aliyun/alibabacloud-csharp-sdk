// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryUnfinishedSessions4ItemsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmItemActivitySessionModelListList")]
        [Validation(Required=false)]
        public QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListList LmItemActivitySessionModelListList { get; set; }
        public class QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListList : TeaModel {
            [NameInMap("LmItemActivitySessionModelList")]
            [Validation(Required=false)]
            public List<QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelList> LmItemActivitySessionModelList { get; set; }
            public class QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelList : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmActivitySessionModels")]
                [Validation(Required=false)]
                public QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelListLmActivitySessionModels LmActivitySessionModels { get; set; }
                public class QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelListLmActivitySessionModels : TeaModel {
                    [NameInMap("LmActivitySessionModel")]
                    [Validation(Required=false)]
                    public List<QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelListLmActivitySessionModelsLmActivitySessionModel> LmActivitySessionModel { get; set; }
                    public class QueryUnfinishedSessions4ItemsResponseBodyLmItemActivitySessionModelListListLmItemActivitySessionModelListLmActivitySessionModelsLmActivitySessionModel : TeaModel {
                        [NameInMap("BizId")]
                        [Validation(Required=false)]
                        public string BizId { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("DisplayDate")]
                        [Validation(Required=false)]
                        public string DisplayDate { get; set; }

                        [NameInMap("EndDate")]
                        [Validation(Required=false)]
                        public string EndDate { get; set; }

                        [NameInMap("ExtInfo")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ExtInfo { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("LmSessionId")]
                        [Validation(Required=false)]
                        public long? LmSessionId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("StartDate")]
                        [Validation(Required=false)]
                        public string StartDate { get; set; }

                        [NameInMap("SubBizCode")]
                        [Validation(Required=false)]
                        public string SubBizCode { get; set; }

                    }

                }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
