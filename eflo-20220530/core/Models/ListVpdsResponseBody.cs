// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVpdsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVpdsResponseBodyContent Content { get; set; }
        public class ListVpdsResponseBodyContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListVpdsResponseBodyContentData> Data { get; set; }
            public class ListVpdsResponseBodyContentData : TeaModel {
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                [NameInMap("Dependence")]
                [Validation(Required=false)]
                public Dictionary<string, object> Dependence { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NcCount")]
                [Validation(Required=false)]
                public int? NcCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Route")]
                [Validation(Required=false)]
                public int? Route { get; set; }

                [NameInMap("ServiceCidr")]
                [Validation(Required=false)]
                public string ServiceCidr { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubnetCount")]
                [Validation(Required=false)]
                public int? SubnetCount { get; set; }

                /// <summary>
                /// vpd id
                /// </summary>
                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
