// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivision20190308.Models
{
    public class GetAlgorithmHistogramsRequest : TeaModel {
        [NameInMap("AlgorithmCode")]
        [Validation(Required=false)]
        public string AlgorithmCode { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("AggregateType")]
        [Validation(Required=false)]
        public string AggregateType { get; set; }

    }

}
