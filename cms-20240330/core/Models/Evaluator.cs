// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Evaluator : TeaModel {
        /// <summary>
        /// <para>The evaluator configuration parameters.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The evaluation filter conditions.</para>
        /// </summary>
        [NameInMap("filters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Filters { get; set; }

        /// <summary>
        /// <para>The evaluator name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_task_completion</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The evaluation result name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_task_completion</para>
        /// </summary>
        [NameInMap("resultName")]
        [Validation(Required=false)]
        public string ResultName { get; set; }

        /// <summary>
        /// <para>The evaluation result type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>score</para>
        /// </summary>
        [NameInMap("resultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// <para>The evaluation variable mapping.</para>
        /// </summary>
        [NameInMap("variableMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> VariableMapping { get; set; }

    }

}
