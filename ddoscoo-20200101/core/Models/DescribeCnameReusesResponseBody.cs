// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCnameReusesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CnameReuses")]
        [Validation(Required=false)]
        public List<DescribeCnameReusesResponseBodyCnameReuses> CnameReuses { get; set; }
        public class DescribeCnameReusesResponseBodyCnameReuses : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

        }

    }

}
