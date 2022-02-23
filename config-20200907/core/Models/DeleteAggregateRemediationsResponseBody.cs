// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateRemediationsResponseBody : TeaModel {
        [NameInMap("RemediationDeleteResults")]
        [Validation(Required=false)]
        public List<DeleteAggregateRemediationsResponseBodyRemediationDeleteResults> RemediationDeleteResults { get; set; }
        public class DeleteAggregateRemediationsResponseBodyRemediationDeleteResults : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
