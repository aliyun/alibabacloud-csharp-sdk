// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateNetworkOptimizationRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable GRPC, disabled by default. Possible values:</para>
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
        /// <para>Indicates whether to enable HTTP2 origin, disabled by default. Possible values:</para>
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
        /// <para>Rule switch. Possible values:</para>
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
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340035003106221</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Version number of the site configuration. For sites with version management enabled, this parameter specifies the version to which the configuration applies, defaulting to version 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable smart routing service, disabled by default. Possible values:</para>
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
        /// <para>Maximum file size for upload, in MB. Range: 100～500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("UploadMaxFilesize")]
        [Validation(Required=false)]
        public string UploadMaxFilesize { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable Websocket, enabled by default. Possible values:</para>
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
