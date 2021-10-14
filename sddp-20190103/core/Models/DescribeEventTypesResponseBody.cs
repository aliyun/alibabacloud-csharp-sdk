// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventTypesResponseBody : TeaModel {
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public List<DescribeEventTypesResponseBodyEventTypeList> EventTypeList { get; set; }
        public class DescribeEventTypesResponseBodyEventTypeList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("SubTypeList")]
            [Validation(Required=false)]
            public List<DescribeEventTypesResponseBodyEventTypeListSubTypeList> SubTypeList { get; set; }
            public class DescribeEventTypesResponseBodyEventTypeListSubTypeList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ConfigContentType")]
                [Validation(Required=false)]
                public int? ConfigContentType { get; set; }

                [NameInMap("EventHitCount")]
                [Validation(Required=false)]
                public int? EventHitCount { get; set; }

                [NameInMap("ConfigValue")]
                [Validation(Required=false)]
                public string ConfigValue { get; set; }

                [NameInMap("ConfigCode")]
                [Validation(Required=false)]
                public string ConfigCode { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("AdaptedProduct")]
                [Validation(Required=false)]
                public string AdaptedProduct { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
