// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateRunRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the experiment associated with the run.</para>
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
        /// <para>The name of the run. The naming convention is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Starts with a lowercase or uppercase letter.</para>
        /// </description></item>
        /// <item><description><para>Can contain lowercase letters, uppercase letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>The length must be 1 to 63 characters.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is left empty, the server-generated random ID (RunID) is used as the name.</para>
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
        /// <para>The ID of the PAI workload associated with the run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-jdnhf***fnrimv</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the PAI workload associated with the run. Options include TrainingService, DLC, or empty. This parameter is optional. The default value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLC</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
