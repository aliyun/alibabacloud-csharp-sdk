// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListCmsInstancesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCmsInstancesResponseBodyData Data { get; set; }
        public class ListCmsInstancesResponseBodyData : TeaModel {
            [NameInMap("EnableTag")]
            [Validation(Required=false)]
            public bool? EnableTag { get; set; }

            [NameInMap("Products")]
            [Validation(Required=false)]
            public List<ListCmsInstancesResponseBodyDataProducts> Products { get; set; }
            public class ListCmsInstancesResponseBodyDataProducts : TeaModel {
                [NameInMap("Descr")]
                [Validation(Required=false)]
                public string Descr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Prod")]
                [Validation(Required=false)]
                public string Prod { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
