// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ListAppEnvironmentResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppEnvironmentResponseBodyData> Data { get; set; }
        public class ListAppEnvironmentResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("AppSchemaId")]
            [Validation(Required=false)]
            public long? AppSchemaId { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }

            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }

            [NameInMap("EnvTypeName")]
            [Validation(Required=false)]
            public string EnvTypeName { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
