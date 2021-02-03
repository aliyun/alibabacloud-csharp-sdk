// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmInstanceGlobalConfigRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        [NameInMap("PublicCnameMode")]
        [Validation(Required=false)]
        public string PublicCnameMode { get; set; }

        [NameInMap("PublicUserDomainName")]
        [Validation(Required=false)]
        public string PublicUserDomainName { get; set; }

        [NameInMap("PublicZoneName")]
        [Validation(Required=false)]
        public string PublicZoneName { get; set; }

        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig : TeaModel {
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

        }

    }

}
