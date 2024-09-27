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
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ADDR_ALERT</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// <para>The name of the alert group in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alertGroup1</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The type of the canonical name (CNAME).</para>
        /// <list type="bullet">
        /// <item><description>Set the value to PUBLIC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable force updates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables force update without a conflict alert.</description></item>
        /// <item><description>false: disables force update. If a conflict occurs, the system displays an alert. null: This valid value of ForceUpdate provides the same information as the false value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance. This parameter is required only for the first update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a custom CNAME domain name or a CNAME domain name assigned by the system to access the instance over the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYSTEM_ASSIGN: a CNAME domain name assigned by the system</description></item>
        /// <item><description>CUSTOM: a custom CNAME domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("PublicCnameMode")]
        [Validation(Required=false)]
        public string PublicCnameMode { get; set; }

        /// <summary>
        /// <para>The hostname corresponding to the CNAME domain name that is used to access the instance over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.rr</para>
        /// </summary>
        [NameInMap("PublicRr")]
        [Validation(Required=false)]
        public string PublicRr { get; set; }

        /// <summary>
        /// <para>The service domain name that is used over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("PublicUserDomainName")]
        [Validation(Required=false)]
        public string PublicUserDomainName { get; set; }

        /// <summary>
        /// <para>The CNAME domain name that is used to access the instance over the Internet, which is the primary domain name. This parameter is required when the PublicCnameMode parameter is set to CUSTOM.</para>
        /// <remarks>
        /// <para> You must use the primary domain name. Do not include the hostname specified by the PublicRr parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-003.com</para>
        /// </summary>
        [NameInMap("PublicZoneName")]
        [Validation(Required=false)]
        public string PublicZoneName { get; set; }

        /// <summary>
        /// <para>The global time to live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
