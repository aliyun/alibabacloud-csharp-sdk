// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogtailPipelineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of aggregator plug-ins.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is valid only when you use an extension processing plug-in. You can use a maximum of one aggregator plug-in.</para>
        /// </summary>
        [NameInMap("aggregators")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Aggregators { get; set; }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The name must be the same as the value of the configName parameter in the request path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The list of output plug-ins.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Currently, you can add only one SLS output plug-in.</para>
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
        /// <para>The list of input plug-ins.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Currently, you can configure only one input plug-in.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Inputs { get; set; }

        /// <summary>
        /// <para>A sample log. Multiple logs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The list of processing plug-ins.</para>
        /// <remarks>
        /// <para>Processing plug-ins are classified into native processing plug-ins and extension processing plug-ins. For more information, see <a href="https://help.aliyun.com/document_detail/64957.html">Processing plug-ins</a>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Native plug-ins can be used only to collect text logs.</para>
        /// </description></item>
        /// <item><description><para>You cannot add native plug-ins and extension plug-ins at the same time.</para>
        /// </description></item>
        /// <item><description><para>When you use native plug-ins, the following requirements must be met:</para>
        /// <list type="bullet">
        /// <item><description><para>The first processing plug-in must be a regular expression-based parsing plug-in, a separator-based parsing plug-in, a JSON-based parsing plug-in, an NGINX-based parsing plug-in, an Apache-based parsing plug-in, or an IIS-based parsing plug-in.</para>
        /// </description></item>
        /// <item><description><para>After the first processing plug-in, you can add only one time parsing plug-in, one filter plug-in, and multiple data masking plug-ins.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Processors { get; set; }

        [NameInMap("task")]
        [Validation(Required=false)]
        public Dictionary<string, object> Task { get; set; }

    }

}
