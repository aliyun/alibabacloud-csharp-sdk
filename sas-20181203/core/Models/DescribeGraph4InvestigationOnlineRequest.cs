// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGraph4InvestigationOnlineRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

        [NameInMap("AnomalyUuid")]
        [Validation(Required=false)]
        public string AnomalyUuid { get; set; }

        [NameInMap("AnomalyId")]
        [Validation(Required=false)]
        public string AnomalyId { get; set; }

        [NameInMap("PathLength")]
        [Validation(Required=false)]
        public int? PathLength { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

    }

}
