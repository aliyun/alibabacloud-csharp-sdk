// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListBindingsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBindingsResponseBodyData Data { get; set; }
        public class ListBindingsResponseBodyData : TeaModel {
            [NameInMap("Bindings")]
            [Validation(Required=false)]
            public List<ListBindingsResponseBodyDataBindings> Bindings { get; set; }
            public class ListBindingsResponseBodyDataBindings : TeaModel {
                [NameInMap("Argument")]
                [Validation(Required=false)]
                public string Argument { get; set; }

                [NameInMap("BindingKey")]
                [Validation(Required=false)]
                public string BindingKey { get; set; }

                [NameInMap("BindingType")]
                [Validation(Required=false)]
                public string BindingType { get; set; }

                [NameInMap("DestinationName")]
                [Validation(Required=false)]
                public string DestinationName { get; set; }

                [NameInMap("SourceExchange")]
                [Validation(Required=false)]
                public string SourceExchange { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
