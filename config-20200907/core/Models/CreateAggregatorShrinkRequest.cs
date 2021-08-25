// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregatorShrinkRequest : TeaModel {
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public string AggregatorAccountsShrink { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("AggregatorType")]
        [Validation(Required=false)]
        public string AggregatorType { get; set; }

    }

}
