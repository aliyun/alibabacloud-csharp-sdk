// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateRunRequest : TeaModel {
        /// <summary>
        /// <para>The experiment ID associated with the run.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-6thbb5xrbmp*****</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <para>The list of labels for the run.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// <para>The name of the run. Naming rules:</para>
        /// <list type="bullet">
        /// <item><description>Must start with a lowercase or uppercase letter.</description></item>
        /// <item><description>Can contain uppercase and lowercase letters, digits, underscores (_), or hyphens (-).</description></item>
        /// <item><description>Must be 1 to 63 characters in length.</description></item>
        /// </list>
        /// <para>If the name is left empty during creation, the server-generated random ID (RunID) is used as the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of parameters for the run.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<RunParam> Params { get; set; }

        /// <summary>
        /// <para>The PAI workload ID associated with the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of PAI workload source associated with the run. Valid values: TrainingService, DLC, or empty. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
