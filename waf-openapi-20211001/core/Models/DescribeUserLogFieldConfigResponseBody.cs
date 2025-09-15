// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserLogFieldConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acl_action,acl_rule_id</para>
        /// </summary>
        [NameInMap("AddList")]
        [Validation(Required=false)]
        public string AddList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success_finished</para>
        /// </summary>
        [NameInMap("ConfigStatus")]
        [Validation(Required=false)]
        public string ConfigStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>waf_rule_id,waf_rule_type</para>
        /// </summary>
        [NameInMap("DelList")]
        [Validation(Required=false)]
        public string DelList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;request_header\&quot;:\&quot;Ali-Cdn-Real-Ip\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>account,acl_action,acl_rule_id,acl_rule_type</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;logType\&quot;:\&quot;blockLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;normalRequestLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;checkLog\&quot;,\&quot;rate\&quot;:100}]</para>
        /// </summary>
        [NameInMap("LogDeliveryStrategy")]
        [Validation(Required=false)]
        public string LogDeliveryStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>653778B4-4D47-5223-855B-4E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
