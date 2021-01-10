// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinktProjectcreatedstatusesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetLinkeLinktProjectcreatedstatusesResponseBodyData> Data { get; set; }
        public class GetLinkeLinktProjectcreatedstatusesResponseBodyData : TeaModel {
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProjectSign")]
            [Validation(Required=false)]
            public string ProjectSign { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Stage")]
            [Validation(Required=false)]
            public long? Stage { get; set; }

            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

        }

    }

}
