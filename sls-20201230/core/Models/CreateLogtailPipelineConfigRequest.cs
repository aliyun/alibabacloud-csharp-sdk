// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLogtailPipelineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation plug-ins.</para>
        /// </summary>
        [NameInMap("aggregators")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Aggregators { get; set; }

        /// <summary>
        /// <para>The name of the configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The data output plug-ins.</para>
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
        /// <para>The data source plug-ins.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Inputs { get; set; }

        /// <summary>
        /// <para>The sample log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The processing plug-ins.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Processors { get; set; }

    }

}
