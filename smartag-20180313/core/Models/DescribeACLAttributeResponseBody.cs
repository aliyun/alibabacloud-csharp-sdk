// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeACLAttributeResponseBody : TeaModel {
        [NameInMap("Acrs")]
        [Validation(Required=false)]
        public DescribeACLAttributeResponseBodyAcrs Acrs { get; set; }
        public class DescribeACLAttributeResponseBodyAcrs : TeaModel {
            [NameInMap("Acr")]
            [Validation(Required=false)]
            public List<DescribeACLAttributeResponseBodyAcrsAcr> Acr { get; set; }
            public class DescribeACLAttributeResponseBodyAcrsAcr : TeaModel {
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("AcrId")]
                [Validation(Required=false)]
                public string AcrId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestCidr")]
                [Validation(Required=false)]
                public string DestCidr { get; set; }

                [NameInMap("DestPortRange")]
                [Validation(Required=false)]
                public string DestPortRange { get; set; }

                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                [NameInMap("DpiGroupIds")]
                [Validation(Required=false)]
                public DescribeACLAttributeResponseBodyAcrsAcrDpiGroupIds DpiGroupIds { get; set; }
                public class DescribeACLAttributeResponseBodyAcrsAcrDpiGroupIds : TeaModel {
                    [NameInMap("DpiGroupId")]
                    [Validation(Required=false)]
                    public List<string> DpiGroupId { get; set; }

                }

                [NameInMap("DpiSignatureIds")]
                [Validation(Required=false)]
                public DescribeACLAttributeResponseBodyAcrsAcrDpiSignatureIds DpiSignatureIds { get; set; }
                public class DescribeACLAttributeResponseBodyAcrsAcrDpiSignatureIds : TeaModel {
                    [NameInMap("DpiSignatureId")]
                    [Validation(Required=false)]
                    public List<string> DpiSignatureId { get; set; }

                }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("SourceCidr")]
                [Validation(Required=false)]
                public string SourceCidr { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
        public int? TotalCount { get; set; }

    }

}
