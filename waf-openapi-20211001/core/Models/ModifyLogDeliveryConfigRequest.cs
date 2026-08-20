// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyLogDeliveryConfigRequest : TeaModel {
        /// <summary>
        /// <para>The log delivery configuration content, which is a string converted from a JSON object constructed with a series of parameters.</para>
        /// <remarks>
        /// <para>This parameter is the same as the <b>DeliveryDetail</b> parameter of the <b>CreateLogDeliveryConfig</b> operation. For more information, see the <b>log delivery configuration content parameter description</b> in the <a href="~~CreateLogDeliveryConfig~~">CreateLogDeliveryConfig</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;rfcVersion&quot;: &quot;rfc3164&quot;,
        ///   &quot;protocol&quot;: &quot;tcp&quot;,
        ///   &quot;servers&quot;: [
        ///     {
        ///       &quot;address&quot;: &quot;1.1.1.1&quot;,
        ///       &quot;port&quot;: 20
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("DeliveryDetail")]
        [Validation(Required=false)]
        public string DeliveryDetail { get; set; }

        /// <summary>
        /// <para>The name of the log delivery configuration to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("DeliveryName")]
        [Validation(Required=false)]
        public string DeliveryName { get; set; }

        /// <summary>
        /// <para>The type of the log delivery configuration to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>syslog</b>: delivers logs to a syslog service.</description></item>
        /// <item><description><b>kafka</b>: delivers logs to a Kafka service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>syslog</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
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
