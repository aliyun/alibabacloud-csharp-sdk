// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBusinessResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBusinessResponseBodyData Data { get; set; }
        public class ListBusinessResponseBodyData : TeaModel {
            [NameInMap("Business")]
            [Validation(Required=false)]
            public List<ListBusinessResponseBodyDataBusiness> Business { get; set; }
            public class ListBusinessResponseBodyDataBusiness : TeaModel {
                public long? BusinessId { get; set; }
                public string BusinessName { get; set; }
                public string Description { get; set; }
                public string Owner { get; set; }
                public long? ProjectId { get; set; }
                public string UseType { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
