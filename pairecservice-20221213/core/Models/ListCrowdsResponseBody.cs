// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListCrowdsResponseBody : TeaModel {
        [NameInMap("Crowds")]
        [Validation(Required=false)]
        public List<ListCrowdsResponseBodyCrowds> Crowds { get; set; }
        public class ListCrowdsResponseBodyCrowds : TeaModel {
            [NameInMap("CrowdId")]
            [Validation(Required=false)]
            public string CrowdId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public string Users { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
