// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateQueryResponseBody : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardRelateQueryResponseBodyModule Module { get; set; }
        public class TravelStandardRelateQueryResponseBodyModule : TeaModel {
            [NameInMap("reserve_bind_entity_list")]
            [Validation(Required=false)]
            public List<TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList> ReserveBindEntityList { get; set; }
            public class TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList : TeaModel {
                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("entity_name")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
