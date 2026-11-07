// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateWebFlowRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh and en. zh indicates Chinese, which is the default value. en indicates English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hkhon1****@c3df23522******</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-a</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The number of additional requests allowed for burst requests. The effect is equivalent to the maximum number of tokens for the token bucket algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Burst")]
        [Validation(Required=false)]
        public int? Burst { get; set; }

        /// <summary>
        /// <para>The flow control method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: fast failure</para>
        /// </description></item>
        /// <item><description><para>2: wait in queue</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ControlBehavior")]
        [Validation(Required=false)]
        public int? ControlBehavior { get; set; }

        /// <summary>
        /// <para>The rule status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (enabled)</para>
        /// </description></item>
        /// <item><description><para>false (disabled)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: milliseconds. This parameter is required if the ControlBehavior parameter is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxQueueingTimeMs")]
        [Validation(Required=false)]
        public int? MaxQueueingTimeMs { get; set; }

        /// <summary>
        /// <para>The threshold type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: number of requests</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public int? MetricType { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The parameter description item, which is a JSON string containing the following key-value pairs:</para>
        /// <list type="bullet">
        /// <item><description><para>parseStrategy: the parameter property (0: client IP address. 1: remote host. 2: header. 3: URL parameter)</para>
        /// </description></item>
        /// <item><description><para>fieldName: the header name or URL parameter name. You must specify this key only if parseStrategy is set to 2 or 3</para>
        /// </description></item>
        /// <item><description><para>matchStrategy: the method to match the property value. You must specify this key only if parseStrategy is set to 2 or 3 and the property value is matched. Valid values: 0 (exact match), 2 (regular expression match), and 3 (substring match)</para>
        /// </description></item>
        /// <item><description><para>pattern: the match string. You must specify this key only if parseStrategy is set to 2 or 3 and the property value is matched</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fieldName&quot;:&quot;key&quot;,&quot;matchStrategy&quot;:2,&quot;parseStrategy&quot;:2,&quot;pattern&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("ParamItem")]
        [Validation(Required=false)]
        public string ParamItem { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: resource name mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResourceMode")]
        [Validation(Required=false)]
        public int? ResourceMode { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The length of the time window. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("StatIntervalMs")]
        [Validation(Required=false)]
        public int? StatIntervalMs { get; set; }

        /// <summary>
        /// <para>The threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
