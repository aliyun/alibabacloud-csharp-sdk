// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListAppResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppResponseBodyData> Data { get; set; }
        public class ListAppResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("AppStateType")]
            [Validation(Required=false)]
            public string AppStateType { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("BizTitle")]
            [Validation(Required=false)]
            public string BizTitle { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("MiddleWareList")]
            [Validation(Required=false)]
            public List<ListAppResponseBodyDataMiddleWareList> MiddleWareList { get; set; }
            public class ListAppResponseBodyDataMiddleWareList : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("OperatingSystem")]
            [Validation(Required=false)]
            public string OperatingSystem { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
