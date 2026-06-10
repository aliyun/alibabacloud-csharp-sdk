// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>Analysis tool. This field does not need to be filled in when using OpenAPI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp/pyki/analysis</para>
        /// </summary>
        [NameInMap("analysisTool")]
        [Validation(Required=false)]
        public string AnalysisTool { get; set; }

        /// <summary>
        /// <para>Data richness</para>
        /// </summary>
        [NameInMap("analysis_params")]
        [Validation(Required=false)]
        public List<string> AnalysisParams { get; set; }

        /// <summary>
        /// <para>Channel name</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_sysom</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>Process name. This is an optional parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python_test</para>
        /// </summary>
        [NameInMap("comms")]
        [Validation(Required=false)]
        public string Comms { get; set; }

        /// <summary>
        /// <para>Creator. You do not need to specify this parameter when using OpenAPI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445333</para>
        /// </summary>
        [NameInMap("created_by")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz9dej066kii4goqxxxx</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>Instance type. This field does not need to be filled in when using OpenAPI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip/sn/hostname</para>
        /// </summary>
        [NameInMap("instance_type")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Iteration entry function. Required only in iteration mode. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Class.function</para>
        /// </summary>
        [NameInMap("iteration_func")]
        [Validation(Required=false)]
        public string IterationFunc { get; set; }

        /// <summary>
        /// <para>Iteration entry module. Required only in iteration mode. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.b.module</para>
        /// </summary>
        [NameInMap("iteration_mod")]
        [Validation(Required=false)]
        public string IterationMod { get; set; }

        /// <summary>
        /// <para>Iteration range (iteration count: the number of iterations when the data collection module is activated, independent of the AI job\&quot;s iteration count)</para>
        /// </summary>
        [NameInMap("iteration_range")]
        [Validation(Required=false)]
        public List<int?> IterationRange { get; set; }

        /// <summary>
        /// <para>Process IDs (PIDs) of the AI job. Batch input is supported, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2421,36547,10043</para>
        /// </summary>
        [NameInMap("pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>AI Infra analysis duration.<br>Unit: milliseconds.<br>Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>Alibaba Cloud User ID. You do not need to specify this parameter when using OpenAPI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123423414</para>
        /// </summary>
        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
