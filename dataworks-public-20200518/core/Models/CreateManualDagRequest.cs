// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateManualDagRequest : TeaModel {
        /// <summary>
        /// <para>The business date. The value must be less than or equal to the current date minus 1 day. For example, if today is November 11, 2020, the business date must be 00:00:00 on November 10, 2020 or an earlier date. The hour, minute, and second values of the business date must all be set to 00.</para>
        /// <para>Format example: <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>2020-11-11 00:00:00</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-11 00:00:00</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>The business process parameters. These parameters are synchronized to all instances of the current dagrun. If the scheduling parameters of internal nodes reference the business process parameters in DagParameters, the corresponding parameter values of the nodes are replaced with the business process parameters in DagParameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kaaaa&quot;: &quot;vaaaaa&quot;, &quot;kbbbb&quot;: &quot;vbbbbb&quot;}</para>
        /// </summary>
        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        /// <summary>
        /// <para>The list of node IDs that do not need to be executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The name of the manual business process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workflow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The list of node IDs that need to be executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>The node parameter information passed when the manual business process is executed. The value is in JSON format:
        /// <c>{      &quot;&lt;Node ID within the manual business process&gt;&quot;: &quot;Scheduling parameter information of the node, in the same format as the parameters in the scheduling configuration of DataStudio&quot;,       &quot;&lt;Node ID within the manual business process&gt;&quot;: &quot;Scheduling parameter information of the node, in the same format as the parameters in the scheduling configuration of DataStudio&quot; }</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;20000123121&quot;: &quot;key1=val2 key2=val2&quot;, &quot;20000123124&quot;: &quot;kkkk=vvvvv aaaa=bbbb&quot;}</para>
        /// </summary>
        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        /// <summary>
        /// <para>The environment identifier of the O&amp;M center. PROD indicates the production environment. DEV indicates the development environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD or DEV</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The English name of the workspace to which the manual business process belongs.</para>
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
