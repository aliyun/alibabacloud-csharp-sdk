// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAllCitiesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Cities")]
        [Validation(Required=false)]
        public QueryAllCitiesResponseBodyCities Cities { get; set; }
        public class QueryAllCitiesResponseBodyCities : TeaModel {
            [NameInMap("City")]
            [Validation(Required=false)]
            public List<QueryAllCitiesResponseBodyCitiesCity> City { get; set; }
            public class QueryAllCitiesResponseBodyCitiesCity : TeaModel {
                public long? CityCode { get; set; }
                public long? ParentId { get; set; }
                public string Name { get; set; }
                public string PinYin { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
