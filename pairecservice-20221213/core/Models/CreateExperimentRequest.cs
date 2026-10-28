// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateExperimentRequest : TeaModel {
        /// <summary>
        /// <para>The experiment configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RankBy&quot;: &quot;Score&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The debug crowd ID. You can call the ListCrowds operation to obtain the debug crowd ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DebugCrowdId")]
        [Validation(Required=false)]
        public string DebugCrowdId { get; set; }

        /// <summary>
        /// <para>The debug users. The value must be the UID of an Alibaba Cloud account or RAM user. Separate multiple UIDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1124512470******,1124512471******,1124512472******</para>
        /// </summary>
        [NameInMap("DebugUsers")]
        [Validation(Required=false)]
        public string DebugUsers { get; set; }

        /// <summary>
        /// <para>The description of the experiment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The experiment group ID. You can call the ListExperimentGroups operation to obtain the experiment group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        /// <summary>
        /// <para>The traffic allocation percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("FlowPercent")]
        [Validation(Required=false)]
        public int? FlowPercent { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the ListInstances operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the experiment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experiment_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the experiment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Baseline: baseline experiment.</description></item>
        /// <item><description>Normal: normal experiment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Baseline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
