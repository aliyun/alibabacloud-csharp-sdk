// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLogtailPipelineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of aggregation plugins. &gt;Notice: This parameter is valid only when you use extension processing plugins. You can use a maximum of one aggregation plugin.</para>
        /// </summary>
        [NameInMap("aggregators")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Aggregators { get; set; }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// <remarks>
        /// <para>The configuration name must be unique within the project and cannot be modified after the configuration is created. The name must follow these rules:</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain only lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 128 characters in length.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The list of output plugins. &gt;Notice: Currently, you can add only one flusher_sls plugin.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("flushers")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Flushers { get; set; }

        /// <summary>
        /// <para>The global configuration.</para>
        /// </summary>
        [NameInMap("global")]
        [Validation(Required=false)]
        public Dictionary<string, object> Global { get; set; }

        /// <summary>
        /// <para>The list of input plugins. &gt;Notice: Currently, you can configure only one input plugin.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Inputs { get; set; }

        /// <summary>
        /// <para>A sample log. Multiple log entries are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The list of processing plugins.</para>
        /// <remarks>
        /// <para>Processing plugins are classified into native processing plugins and extension processing plugins. For more information, see <a href="https://help.aliyun.com/document_detail/64957.html">Processing plugins</a>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Native plugins can be used only to collect text logs.</para>
        /// </description></item>
        /// <item><description><para>You cannot add native plugins and extension plugins at the same time.</para>
        /// </description></item>
        /// <item><description><para>When you use native plugins, the following requirements must be met:</para>
        /// <list type="bullet">
        /// <item><description><para>The first processing plugin must be a regular expression-based parsing plugin, a separator-based parsing plugin, a JSON-based parsing plugin, an NGINX-based parsing plugin, an Apache-based parsing plugin, or an IIS-based parsing plugin.</para>
        /// </description></item>
        /// <item><description><para>After the first processing plugin, you can add only one time parsing processing plugin, one filter plugin, and multiple data masking plugins.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Processors { get; set; }

        /// <summary>
        /// <para>The task configuration.</para>
        /// </summary>
        [NameInMap("task")]
        [Validation(Required=false)]
        public Dictionary<string, object> Task { get; set; }

    }

}
