// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListFunctionResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListFunctionResponseBodyDataList> DataList { get; set; }
        public class ListFunctionResponseBodyDataList : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("HttpTriggerPath")]
            [Validation(Required=false)]
            public string HttpTriggerPath { get; set; }

            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public ListFunctionResponseBodyDataListSpec Spec { get; set; }
            public class ListFunctionResponseBodyDataListSpec : TeaModel {
                [NameInMap("InstanceConcurrency")]
                [Validation(Required=false)]
                public int? InstanceConcurrency { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }
                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }
            };

            [NameInMap("TimingTriggerConfig")]
            [Validation(Required=false)]
            public string TimingTriggerConfig { get; set; }

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public ListFunctionResponseBodyPaginator Paginator { get; set; }
        public class ListFunctionResponseBodyPaginator : TeaModel {
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
