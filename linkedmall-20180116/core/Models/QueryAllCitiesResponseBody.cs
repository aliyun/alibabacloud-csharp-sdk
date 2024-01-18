// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryAllCitiesResponseBody : TeaModel {
        [NameInMap("Cities")]
        [Validation(Required=false)]
        public QueryAllCitiesResponseBodyCities Cities { get; set; }
        public class QueryAllCitiesResponseBodyCities : TeaModel {
            [NameInMap("City")]
            [Validation(Required=false)]
            public List<QueryAllCitiesResponseBodyCitiesCity> City { get; set; }
            public class QueryAllCitiesResponseBodyCitiesCity : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public long? CityCode { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("PinYin")]
                [Validation(Required=false)]
                public string PinYin { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
