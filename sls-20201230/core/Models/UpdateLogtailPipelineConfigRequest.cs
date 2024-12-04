// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogtailPipelineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation plug-ins.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when extended plug-ins are used. You can use only one aggregation plug-in.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("aggregators")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Aggregators { get; set; }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// <remarks>
        /// <para> The value of this parameter must be the same as the value of configName in the outer layer.</para>
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
        /// <para>The output plug-ins.</para>
        /// <remarks>
        /// <para> You can use only one Simple Log Service output plug-in.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("flushers")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Flushers { get; set; }

        /// <summary>
        /// <para>The global settings.</para>
        /// <para>**</para>
        /// <hr>
        /// </summary>
        [NameInMap("global")]
        [Validation(Required=false)]
        public Dictionary<string, object> Global { get; set; }

        /// <summary>
        /// <para>The input plug-ins.</para>
        /// <remarks>
        /// <para> You can configure only one input plug-in.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Inputs { get; set; }

        /// <summary>
        /// <para>The sample log. You can specify multiple sample logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The processing plug-ins.</para>
        /// <remarks>
        /// <para> Logtail supports native plug-ins and extended plug-ins for data processing. For more information, see <a href="https://help.aliyun.com/document_detail/64957.html">Logtail plug-ins overview</a>.</para>
        /// </remarks>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can use native plug-ins only to collect text logs.</para>
        /// </description></item>
        /// <item><description><para>You cannot add native plug-ins and extended plug-ins at the same time.</para>
        /// </description></item>
        /// <item><description><para>When you add native plug-ins, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>You must add one of the following Logtail plug-ins for data processing as the first plug-in: Data Parsing (Regex Mode), Data Parsing (Delimiter Mode), Data Parsing (JSON Mode), Data Parsing (NGINX Mode), Data Parsing (Apache Mode), and Data Parsing (IIS Mode).</description></item>
        /// <item><description>After you add the first plug-in, you can add one Time Parsing plug-in, one Data Filtering plug-in, and multiple Data Masking plug-ins.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Processors { get; set; }

    }

}
