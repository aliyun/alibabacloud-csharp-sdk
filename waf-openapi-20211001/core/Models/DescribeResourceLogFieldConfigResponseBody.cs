// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceLogFieldConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The extra log fields that are configured in addition to the default log fields. The fields are specified as a string of comma-separated values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl_test,acl_action,acl_rule_id,waf_test,acl_rule_type</para>
        /// </summary>
        [NameInMap("AddList")]
        [Validation(Required=false)]
        public string AddList { get; set; }

        /// <summary>
        /// <para>The log fields that are removed from the default log fields. The fields are specified as a string of comma-separated values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_rule_id,waf_rule_type</para>
        /// </summary>
        [NameInMap("DelList")]
        [Validation(Required=false)]
        public string DelList { get; set; }

        /// <summary>
        /// <para>The log delivery type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sls</b>: Simple Log Service.</para>
        /// </description></item>
        /// <item><description><para><b>kafka</b>: Kafka.</para>
        /// </description></item>
        /// <item><description><para><b>syslog</b>: Syslog.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <para>The extended configuration for log delivery. The value is a string that is converted from a JSON object of parameters.</para>
        /// <remarks>
        /// <para>For more information about the parameters, see the description of the <b>ExtendConfig</b> parameter in <a href="~~ModifyResourceLogFieldConfig~~">ModifyResourceLogFieldConfig</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;request_header\&quot;:\&quot;Ali-Cdn-Real-Ip\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <para>The list of delivered log fields. The fields are specified as a string of comma-separated values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account,acl_action,acl_rule_id,acl_rule_type,acl_test,antiscan_action,antiscan_rule_id,antiscan_rule_type,antiscan_test,body_bytes_sent,bypass_matched_ids</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The log delivery policies. Multiple policies are supported. The value is a string that is converted from a JSON array of parameters.</para>
        /// <remarks>
        /// <para>For more information about the parameters, see the description of the <b>LogDeliveryStrategy</b> parameter in <a href="~~ModifyResourceLogFieldConfig~~">ModifyResourceLogFieldConfig</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;logType\&quot;:\&quot;blockLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;normalRequestLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;checkLog\&quot;,\&quot;rate\&quot;:100}]</para>
        /// </summary>
        [NameInMap("LogDeliveryStrategy")]
        [Validation(Required=false)]
        public string LogDeliveryStrategy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B53B47C-D368-5344-BB5E-79******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
