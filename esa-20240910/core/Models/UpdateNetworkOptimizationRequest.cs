// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateNetworkOptimizationRequest : TeaModel {
        /// <summary>
        /// <para>Configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>352816096987136</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Whether to enable GRPC, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable</description></item>
        /// <item><description>off: Disable</description></item>
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
        /// <item><description>on: Enable</description></item>
        /// <item><description>off: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Http2Origin")]
        [Validation(Required=false)]
        public string Http2Origin { get; set; }

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
        /// <item><description>on: Enable</description></item>
        /// <item><description>off: Disable</description></item>
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
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Whether to enable smart routing service, default is disabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable</description></item>
        /// <item><description>off: Disable</description></item>
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
        /// <para>100</para>
        /// </summary>
        [NameInMap("UploadMaxFilesize")]
        [Validation(Required=false)]
        public string UploadMaxFilesize { get; set; }

        /// <summary>
        /// <para>Whether to enable Websocket, default is enabled. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enable</description></item>
        /// <item><description>off: Disable</description></item>
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
