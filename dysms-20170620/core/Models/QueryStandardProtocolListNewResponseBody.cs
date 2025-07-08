// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryStandardProtocolListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryStandardProtocolListNewResponseBodyList> List { get; set; }
        public class QueryStandardProtocolListNewResponseBodyList : TeaModel {
            [NameInMap("AuditOrderId")]
            [Validation(Required=false)]
            public string AuditOrderId { get; set; }

            [NameInMap("CorpCode")]
            [Validation(Required=false)]
            public string CorpCode { get; set; }

            [NameInMap("EffIpWhiteList")]
            [Validation(Required=false)]
            public string EffIpWhiteList { get; set; }

            [NameInMap("FeatureCode")]
            [Validation(Required=false)]
            public int? FeatureCode { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("IpAuditStatus")]
            [Validation(Required=false)]
            public int? IpAuditStatus { get; set; }

            [NameInMap("IpWhiteList")]
            [Validation(Required=false)]
            public string IpWhiteList { get; set; }

            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("ProfileId")]
            [Validation(Required=false)]
            public long? ProfileId { get; set; }

            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public int? ProtocolType { get; set; }

            [NameInMap("ProtocolTypeStr")]
            [Validation(Required=false)]
            public string ProtocolTypeStr { get; set; }

            [NameInMap("RealNameInsId")]
            [Validation(Required=false)]
            public long? RealNameInsId { get; set; }

            [NameInMap("ResCode")]
            [Validation(Required=false)]
            public string ResCode { get; set; }

            [NameInMap("SmsSign")]
            [Validation(Required=false)]
            public string SmsSign { get; set; }

            [NameInMap("SmsType")]
            [Validation(Required=false)]
            public string SmsType { get; set; }

            [NameInMap("SpCode")]
            [Validation(Required=false)]
            public string SpCode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("UserLimit")]
            [Validation(Required=false)]
            public int? UserLimit { get; set; }

            [NameInMap("UserMaxChannel")]
            [Validation(Required=false)]
            public int? UserMaxChannel { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("UserPwd")]
            [Validation(Required=false)]
            public string UserPwd { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
