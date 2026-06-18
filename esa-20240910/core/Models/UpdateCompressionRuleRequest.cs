// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCompressionRuleRequest : TeaModel {
        /// <summary>
        /// <para>Brotli compression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enable.</para>
        /// </description></item>
        /// <item><description><para>off: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Brotli")]
        [Validation(Required=false)]
        public string Brotli { get; set; }

        /// <summary>
        /// <para>Configuration ID. Get this value by calling the <a href="~~ListCompressionRules~~">ListCompressionRules</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>Gzip compression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enable.</para>
        /// </description></item>
        /// <item><description><para>off: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// <para>Rule content, using a conditional expression to match user requests. Do not set this parameter when adding a global configuration. Two scenarios apply:</para>
        /// <list type="bullet">
        /// <item><description><para>Match all incoming requests: Set the value to true.</para>
        /// </description></item>
        /// <item><description><para>Match specific requests: Set the value to a custom expression, such as: (http.host eq &quot;video.example.com&quot;)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Rule switch. Do not set this parameter when adding a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enable.</para>
        /// </description></item>
        /// <item><description><para>off: Disable.</para>
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
        /// <para>Rule name. Do not set this parameter when adding a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Rule execution order. Rules with smaller values take precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>Site ID. Get this value by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Zstd compression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enable.</para>
        /// </description></item>
        /// <item><description><para>off: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Zstd")]
        [Validation(Required=false)]
        public string Zstd { get; set; }

    }

}
