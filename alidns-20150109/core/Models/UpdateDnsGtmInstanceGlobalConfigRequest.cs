// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmInstanceGlobalConfigRequest : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig : TeaModel {
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// The name of the alert group in the JSON format.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// The type of the canonical name (CNAME).
        /// 
        /// *   Set the value to PUBLIC.
        /// </summary>
        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        /// <summary>
        /// Specifies whether to enable force updates. Valid values:
        /// 
        /// *   true: enables force update without a conflict alert.
        /// *   false: disables force update. If a conflict occurs, the system displays an alert. null: This valid value of ForceUpdate provides the same information as the false value.
        /// </summary>
        [NameInMap("ForceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the instance. This parameter is required only for the first update.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to use a custom CNAME domain name or a CNAME domain name assigned by the system to access the instance over the Internet. Valid values:
        /// 
        /// *   SYSTEM_ASSIGN: a CNAME domain name assigned by the system
        /// *   CUSTOM: a custom CNAME domain name
        /// </summary>
        [NameInMap("PublicCnameMode")]
        [Validation(Required=false)]
        public string PublicCnameMode { get; set; }

        /// <summary>
        /// The hostname corresponding to the CNAME domain name that is used to access the instance over the Internet.
        /// </summary>
        [NameInMap("PublicRr")]
        [Validation(Required=false)]
        public string PublicRr { get; set; }

        /// <summary>
        /// The service domain name that is used over the Internet.
        /// </summary>
        [NameInMap("PublicUserDomainName")]
        [Validation(Required=false)]
        public string PublicUserDomainName { get; set; }

        /// <summary>
        /// The CNAME domain name that is used to access the instance over the Internet, which is the primary domain name. This parameter is required when the PublicCnameMode parameter is set to CUSTOM.
        /// 
        /// >  You must use the primary domain name. Do not include the hostname specified by the PublicRr parameter.
        /// </summary>
        [NameInMap("PublicZoneName")]
        [Validation(Required=false)]
        public string PublicZoneName { get; set; }

        /// <summary>
        /// The global time to live (TTL).
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
