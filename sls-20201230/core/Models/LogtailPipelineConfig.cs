// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailPipelineConfig : TeaModel {
        [NameInMap("aggregators")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Aggregators { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("flushers")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Flushers { get; set; }

        [NameInMap("global")]
        [Validation(Required=false)]
        public Dictionary<string, object> Global { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputs")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Inputs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>127.0.0.1 - - [10/Jun/2022:12:36:49 +0800] &quot;GET /index.html HTTP/1.1&quot; 200</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Processors { get; set; }

    }

}
