// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIAnalysisRequest : TeaModel {
        [NameInMap("analysisTool")]
        [Validation(Required=false)]
        public string AnalysisTool { get; set; }

        [NameInMap("analysis_params")]
        [Validation(Required=false)]
        public List<string> AnalysisParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs_sysom</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python_test</para>
        /// </summary>
        [NameInMap("comms")]
        [Validation(Required=false)]
        public string Comms { get; set; }

        [NameInMap("created_by")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-wz9dej066kii4goqxxxx</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        [NameInMap("instance_type")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("iteration_func")]
        [Validation(Required=false)]
        public string IterationFunc { get; set; }

        [NameInMap("iteration_mod")]
        [Validation(Required=false)]
        public string IterationMod { get; set; }

        [NameInMap("iteration_range")]
        [Validation(Required=false)]
        public List<int?> IterationRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2421,36547,10043</para>
        /// </summary>
        [NameInMap("pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
