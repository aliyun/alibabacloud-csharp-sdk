// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserLogFieldConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log fields that are configured in addition to the default log fields, in the format of &quot;a,b,c,...&quot;.</para>
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
        /// <item><description><b>initial</b>: The configuration is in the initialization state.</description></item>
        /// <item><description><b>updating</b>: The configuration is being updated.</description></item>
        /// <item><description><b>failed_finished</b>: The configuration failed.</description></item>
        /// <item><description><b>success_finished</b>: The configuration succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success_finished</para>
        /// </summary>
        [NameInMap("ConfigStatus")]
        [Validation(Required=false)]
        public string ConfigStatus { get; set; }

        /// <summary>
        /// <para>The list of log fields that are excluded from the default log fields, in the format of &quot;a,b,c,...&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_rule_id,waf_rule_type</para>
        /// </summary>
        [NameInMap("DelList")]
        [Validation(Required=false)]
        public string DelList { get; set; }

        /// <summary>
        /// <para>The delivery type. Valid values:</para>
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
        /// <para>The extended configuration for log delivery. The value is a string converted from a JSON object constructed with a series of parameters.</para>
        /// <remarks>
        /// <para>For more information about the parameters, see the <b>ExtendConfig</b> parameter description in the <a href="~~ModifyUserLogFieldConfig~~">ModifyUserLogFieldConfig</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;request_header\&quot;:\&quot;Ali-Cdn-Real-Ip\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <para>The list of log fields to be delivered, in the format of &quot;a,b,c,...&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account,acl_action,acl_rule_id,acl_rule_type</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The log delivery strategy. Multiple strategies are supported. The value is a string converted from a JSON array constructed with a series of parameters.</para>
        /// <remarks>
        /// <para>For more information about the parameters, see the <b>LogDeliveryStrategy</b> parameter description in the <a href="~~ModifyUserLogFieldConfig~~">ModifyUserLogFieldConfig</a> operation.</para>
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
        /// <para>653778B4-4D47-5223-855B-4E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
