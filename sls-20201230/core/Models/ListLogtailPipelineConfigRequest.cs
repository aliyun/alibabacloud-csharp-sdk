// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListLogtailPipelineConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the Logtail pipeline configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logtail-config-sample</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The name of the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The line from which the query starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The number of Logtail pipeline configurations per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
