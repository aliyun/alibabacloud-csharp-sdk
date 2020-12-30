// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeACLAttributeResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Acrs")]
        [Validation(Required=false)]
        public DescribeACLAttributeResponseBodyAcrs Acrs { get; set; }
        public class DescribeACLAttributeResponseBodyAcrs : TeaModel {
            [NameInMap("Acr")]
            [Validation(Required=false)]
            public List<DescribeACLAttributeResponseBodyAcrsAcr> Acr { get; set; }
            public class DescribeACLAttributeResponseBodyAcrsAcr : TeaModel {
                public string Direction { get; set; }
                public string Type { get; set; }
                public DescribeACLAttributeResponseBodyAcrsAcrDpiSignatureIds DpiSignatureIds { get; set; }
                public class DescribeACLAttributeResponseBodyAcrsAcrDpiSignatureIds : TeaModel {
                    [NameInMap("DpiSignatureId")]
                    [Validation(Required=false)]
                    public List<string> DpiSignatureId { get; set; }

                }
                public string IpProtocol { get; set; }
                public int? Priority { get; set; }
                public string AclId { get; set; }
                public string Policy { get; set; }
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public string DestCidr { get; set; }
                public string DestPortRange { get; set; }
                public string Name { get; set; }
                public string AcrId { get; set; }
                public string SourceCidr { get; set; }
                public string SourcePortRange { get; set; }
                public DescribeACLAttributeResponseBodyAcrsAcrDpiGroupIds DpiGroupIds { get; set; }
                public class DescribeACLAttributeResponseBodyAcrsAcrDpiGroupIds : TeaModel {
                    [NameInMap("DpiGroupId")]
                    [Validation(Required=false)]
                    public List<string> DpiGroupId { get; set; }

                }
            }
        };

    }

}
