// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateNetworkOptimizationRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Controls whether gRPC is enabled. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: gRPC is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: gRPC is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Grpc")]
        [Validation(Required=false)]
        public string Grpc { get; set; }

        /// <summary>
        /// <para>Controls whether HTTP/2 to origin is enabled. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: HTTP/2 to origin is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: HTTP/2 to origin is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http2Origin")]
        [Validation(Required=false)]
        public string Http2Origin { get; set; }

        /// <summary>
        /// <para>The conditional expression used to match requests. This parameter is optional for global configurations.</para>
        /// <list type="bullet">
        /// <item><description><para>To match all incoming requests, set the value to true.</para>
        /// </description></item>
        /// <item><description><para>To match specific requests, set the value to a custom expression, for example, (http.host eq &quot;video.example.com&quot;).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Controls whether the rule is enabled. This parameter is optional for global configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: The rule is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. This parameter is optional for global configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. Smaller values have higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. Call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Controls whether smart routing is enabled. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Smart routing is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: Smart routing is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SmartRouting")]
        [Validation(Required=false)]
        public string SmartRouting { get; set; }

        /// <summary>
        /// <para>The maximum upload file size, in MB. The value must be an integer from 100 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UploadMaxFilesize")]
        [Validation(Required=false)]
        public string UploadMaxFilesize { get; set; }

        /// <summary>
        /// <para>Controls whether WebSocket is enabled. This feature is enabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: WebSocket is enabled.</para>
        /// </description></item>
        /// <item><description><para>off: WebSocket is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Websocket")]
        [Validation(Required=false)]
        public string Websocket { get; set; }

    }

}
