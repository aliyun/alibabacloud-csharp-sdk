// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateManualDagRequest : TeaModel {
        /// <summary>
        /// <para>The data timestamp. The value of the data timestamp must be one or more days before the current date. For example, if the current date is November 11, 2020, set the value to 2020-11-10 00:00:00 or earlier. Configure this parameter in the YYYY-MM-DD 00:00:00 format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-11 00:00:00</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>The parameters of the manually triggered workflow, which are synchronized to all the instances in the directed acyclic graph (DAG) of the workflow. If a workflow parameter specified in DagParameters is referenced as a scheduling parameter of a node, the value of the scheduling parameter is replaced with the value of the workflow parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kaaaa&quot;: &quot;vaaaaa&quot;, &quot;kbbbb&quot;: &quot;vbbbbb&quot;}</para>
        /// </summary>
        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes that do not need to be run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The name of the manually triggered workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workflow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes that you want to run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>The parameters transmitted between nodes in the manually triggered workflow. The parameters are in the following JSON format: <c>{ &quot;&lt;ID of a node in the manually triggered workflow&gt;&quot;: &quot;Scheduling parameter settings of the node, which are in the same format as the parameters in the Scheduling Parameter section on the Properties tab of the DataStudio page&quot;, &quot;&lt;ID of a node in the manually triggered workflow&gt;&quot;: &quot;Scheduling parameter settings of the node, which are in the same format as the parameters in the Scheduling Parameter section on the Properties tab of the DataStudio page&quot; }</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;20000123121&quot;: &quot;key1=val2 key2=val2&quot;, &quot;20000123124&quot;: &quot;kkkk=vvvvv aaaa=bbbb&quot;}</para>
        /// </summary>
        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        /// <summary>
        /// <para>The environment type of Operation Center. Valid values: PROD and DEV.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the manually triggered workflow belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workspace</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
