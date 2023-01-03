// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListSubnetsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListSubnetsResponseBodyContent Content { get; set; }
        public class ListSubnetsResponseBodyContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSubnetsResponseBodyContentData> Data { get; set; }
            public class ListSubnetsResponseBodyContentData : TeaModel {
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NcCount")]
                [Validation(Required=false)]
                public long? NcCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubnetId")]
                [Validation(Required=false)]
                public string SubnetId { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VpdBaseInfo")]
                [Validation(Required=false)]
                public ListSubnetsResponseBodyContentDataVpdBaseInfo VpdBaseInfo { get; set; }
                public class ListSubnetsResponseBodyContentDataVpdBaseInfo : TeaModel {
                    [NameInMap("Cidr")]
                    [Validation(Required=false)]
                    public string Cidr { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("VpdId")]
                    [Validation(Required=false)]
                    public string VpdId { get; set; }

                }

                [NameInMap("VpdId")]
                [Validation(Required=false)]
                public string VpdId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
