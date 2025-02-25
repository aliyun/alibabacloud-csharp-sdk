// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetNetworkOptimizationResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Configuration type, which can be used to query global or rule configurations. Value range:</para>
        /// <list type="bullet">
        /// <item><description>global: Query global configuration.</description></item>
        /// <item><description>rule: Query rule configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>Whether to enable GRPC, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled</description></item>
        /// <item><description>off: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Grpc")]
        [Validation(Required=false)]
        public string Grpc { get; set; }

        /// <summary>
        /// <para>Whether to enable HTTP2 origin, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled</description></item>
        /// <item><description>off: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http2Origin")]
        [Validation(Required=false)]
        public string Http2Origin { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Rule content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Rule switch. Values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled</description></item>
        /// <item><description>off: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>Rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Rule execution sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Site version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Whether to enable smart routing service, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled</description></item>
        /// <item><description>off: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SmartRouting")]
        [Validation(Required=false)]
        public string SmartRouting { get; set; }

        /// <summary>
        /// <para>Maximum upload file size, in MB, value range: 100～500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("UploadMaxFilesize")]
        [Validation(Required=false)]
        public string UploadMaxFilesize { get; set; }

        /// <summary>
        /// <para>Whether to enable Websocket, default is enabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled</description></item>
        /// <item><description>off: Disabled</description></item>
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
