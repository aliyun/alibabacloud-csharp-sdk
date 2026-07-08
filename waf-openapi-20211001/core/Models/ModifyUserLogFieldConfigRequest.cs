// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyUserLogFieldConfigRequest : TeaModel {
        /// <summary>
        /// <para>The delivery type. Valid value:</para>
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
        /// <para>The extended configuration for log delivery, in JSON format.</para>
        /// <remarks>
        /// <para>For more information, see the description of the <b>ExtendConfig</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;request_header\&quot;:\&quot;App-Id,channelCode\&quot;}</para>
        /// </summary>
        [NameInMap("ExtendConfig")]
        [Validation(Required=false)]
        public string ExtendConfig { get; set; }

        /// <summary>
        /// <para>The list of log fields to deliver. Use the \<c>a,b,c,...\\</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must include all required log fields. Call the <a href="~~DescribeCommonLogFields~~">DescribeCommonLogFields</a> operation to view the log fields that WAF supports.</para>
        /// </description></item>
        /// <item><description><para>If the log fields include <b>request_header</b>, use the <b>ExtendConfig</b> parameter to specify the request headers to deliver.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>account,acl_action,acl_rule_id,acl_rule_type,acl_test,antiscan_action,antiscan_rule_id,antiscan_rule_type,antiscan_test,body_bytes_sent,bypass_matched_ids</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to view the ID of your WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-fou****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The log delivery strategy, in JSON array format. You can specify multiple strategies.</para>
        /// <remarks>
        /// <para>For more information, see the description of the <b>LogDeliveryStrategy</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;logType\&quot;:\&quot;blockLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;normalRequestLog\&quot;,\&quot;rate\&quot;:100},{\&quot;logType\&quot;:\&quot;checkLog\&quot;,\&quot;rate\&quot;:100}]</para>
        /// </summary>
        [NameInMap("LogDeliveryStrategy")]
        [Validation(Required=false)]
        public string LogDeliveryStrategy { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
