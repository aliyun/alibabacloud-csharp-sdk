// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ListItemActivitiesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LmItemActivityModelList")]
        [Validation(Required=false)]
        public ListItemActivitiesResponseBodyLmItemActivityModelList LmItemActivityModelList { get; set; }
        public class ListItemActivitiesResponseBodyLmItemActivityModelList : TeaModel {
            [NameInMap("LmItemActivityModel")]
            [Validation(Required=false)]
            public List<ListItemActivitiesResponseBodyLmItemActivityModelListLmItemActivityModel> LmItemActivityModel { get; set; }
            public class ListItemActivitiesResponseBodyLmItemActivityModelListLmItemActivityModel : TeaModel {
                [NameInMap("SubBizCode")]
                [Validation(Required=false)]
                public string SubBizCode { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("DisplayDate")]
                [Validation(Required=false)]
                public string DisplayDate { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtInfo { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
