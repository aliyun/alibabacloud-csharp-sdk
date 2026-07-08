// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserLogFieldConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The additional log fields that are added to the default configuration. Multiple fields are separated by commas (,) in the <c>a,b,c,...</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl_action,acl_rule_id</para>
        /// </summary>
        [NameInMap("AddList")]
        [Validation(Required=false)]
        public string AddList { get; set; }

        /// <summary>
        /// <para>The status of the log field configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>initial</b>: The log field configuration is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>updating</b>: The log field configuration is being updated.</para>
        /// </description></item>
        /// <item><description><para><b>failed_finished</b>: The log field configuration update failed.</para>
        /// </description></item>
        /// <item><description><para><b>success_finished</b>: The log field configuration update succeeded.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success_finished</para>
        /// </summary>
        [NameInMap("ConfigStatus")]
        [Validation(Required=false)]
        public string ConfigStatus { get; set; }

        /// <summary>
        /// <para>The default log fields that are excluded from the log delivery configuration. Multiple fields are separated by commas (,) in the <c>a,b,c,...</c> format.</para>
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
        /// <item><description><b>sls</b>: Simple Log Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <para>The extended configuration for log delivery. The value is a JSON-formatted string that contains configuration key-value pairs, such as custom request headers.</para>
        /// <remarks>
        /// <para>For more information, see the <b>ExtendConfig</b> parameter description in <a href="~~ModifyUserLogFieldConfig~~">ModifyUserLogFieldConfig</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;request_header\&quot;:\&quot;Ali-Cdn-Real-Ip\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <para>The complete list of log fields that are delivered. Multiple fields are separated by commas (,) in the <c>a,b,c,...</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account,acl_action,acl_rule_id,acl_rule_type</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The log delivery policies. Multiple policies are supported. The value is a JSON-formatted string that contains an array of policy objects.</para>
        /// <remarks>
        /// <para>For more information, see the <b>LogDeliveryStrategy</b> parameter description in <a href="~~ModifyUserLogFieldConfig~~">ModifyUserLogFieldConfig</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;logType\&quot;:\&quot;blockLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;normalRequestLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;checkLog\&quot;,\&quot;rate\&quot;:100}]</para>
        /// </summary>
        [NameInMap("LogDeliveryStrategy")]
        [Validation(Required=false)]
        public string LogDeliveryStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>653778B4-4D47-5223-855B-4E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
