// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSchemasConnPropsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPSchemasConnPropsResponseBodyData Data { get; set; }
        public class QueryODPSchemasConnPropsResponseBodyData : TeaModel {
            [NameInMap("AllowMinPoolTimeout")]
            [Validation(Required=false)]
            public bool? AllowMinPoolTimeout { get; set; }
            [NameInMap("BackgroundValidation")]
            [Validation(Required=false)]
            public bool? BackgroundValidation { get; set; }
            [NameInMap("BackgroundValidationMinutes")]
            [Validation(Required=false)]
            public long? BackgroundValidationMinutes { get; set; }
            [NameInMap("BlockingTimeoutMillis")]
            [Validation(Required=false)]
            public long? BlockingTimeoutMillis { get; set; }
            [NameInMap("IdleTimeoutMinutes")]
            [Validation(Required=false)]
            public long? IdleTimeoutMinutes { get; set; }
            [NameInMap("MaxConn")]
            [Validation(Required=false)]
            public long? MaxConn { get; set; }
            [NameInMap("MinConn")]
            [Validation(Required=false)]
            public long? MinConn { get; set; }
            [NameInMap("NewConnectionSql")]
            [Validation(Required=false)]
            public string NewConnectionSql { get; set; }
            [NameInMap("Others")]
            [Validation(Required=false)]
            public string Others { get; set; }
            [NameInMap("Prefill")]
            [Validation(Required=false)]
            public bool? Prefill { get; set; }
            [NameInMap("QueryTimeout")]
            [Validation(Required=false)]
            public long? QueryTimeout { get; set; }
            [NameInMap("TestOnBorrow")]
            [Validation(Required=false)]
            public bool? TestOnBorrow { get; set; }
            [NameInMap("ValidationQuery")]
            [Validation(Required=false)]
            public string ValidationQuery { get; set; }
            [NameInMap("ValidationQueryTimeout")]
            [Validation(Required=false)]
            public long? ValidationQueryTimeout { get; set; }
        };

    }

}
