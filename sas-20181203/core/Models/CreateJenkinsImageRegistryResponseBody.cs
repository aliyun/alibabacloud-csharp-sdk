// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageRegistryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateJenkinsImageRegistryResponseBodyData Data { get; set; }
        public class CreateJenkinsImageRegistryResponseBodyData : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public string BlackList { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public int? NetType { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("PersistenceDay")]
            [Validation(Required=false)]
            public int? PersistenceDay { get; set; }
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public int? ProtocolType { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RegistryHostIp")]
            [Validation(Required=false)]
            public string RegistryHostIp { get; set; }
            [NameInMap("RegistryName")]
            [Validation(Required=false)]
            public string RegistryName { get; set; }
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("TransPerHour")]
            [Validation(Required=false)]
            public int? TransPerHour { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
