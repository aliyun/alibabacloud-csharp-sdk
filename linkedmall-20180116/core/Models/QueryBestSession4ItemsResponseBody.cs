// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBestSession4ItemsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmItemActivitySessionModelList")]
        [Validation(Required=false)]
        public QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelList LmItemActivitySessionModelList { get; set; }
        public class QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelList : TeaModel {
            [NameInMap("LmItemActivitySessionModel")]
            [Validation(Required=false)]
            public List<QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelListLmItemActivitySessionModel> LmItemActivitySessionModel { get; set; }
            public class QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelListLmItemActivitySessionModel : TeaModel {
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("LmActivitySessionModel")]
                [Validation(Required=false)]
                public QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelListLmItemActivitySessionModelLmActivitySessionModel LmActivitySessionModel { get; set; }
                public class QueryBestSession4ItemsResponseBodyLmItemActivitySessionModelListLmItemActivitySessionModelLmActivitySessionModel : TeaModel {
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
