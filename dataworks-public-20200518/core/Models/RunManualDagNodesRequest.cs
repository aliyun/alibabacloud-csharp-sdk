// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunManualDagNodesRequest : TeaModel {
        /// <summary>
        /// <para>The business date. The value must be less than or equal to the current date minus 1 day. For example, if today is November 11, 2020, the business date must be 00:00:00 on November 10, 2020 or an earlier date. The hour, minute, and second values of the business date must all be set to 00.</para>
        /// <para>This parameter is used together with the StartBizDate and EndBizDate parameters. You can configure only one of BizDate or the StartBizDate and EndBizDate pair.</para>
        /// <para>Format: <c>yyyy-MM-dd HH:mm:ss</c>. Example: <c>2020-11-11 00:00:00</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-11 00:00:00</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// <para>This parameter is synchronized to all instances of the current dagrun. If the scheduling parameters of internal nodes (<a href="https://help.aliyun.com/document_detail/147245.html">supported node types</a>) reference workflow parameters in DagParameters, the corresponding parameter values of the nodes are replaced with the workflow parameters in DagParameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kaaaa&quot;: &quot;vaaaaa&quot;, &quot;kbbbb&quot;: &quot;vbbbbb&quot;}</para>
        /// </summary>
        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        /// <summary>
        /// <para>The business end date. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is used together with the StartBizDate parameter. You can configure only one of the StartBizDate and EndBizDate pair or the BizDate parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-03 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// <para>The IDs of nodes that you do not want to run within the workflow. The specified nodes generate dry-run instances during execution. After a dry-run instance is scheduled, it immediately succeeds without executing the script content. Separate multiple node IDs with commas (,).</para>
        /// <para>The ExcludeNodeIds parameter takes effect only when used together with the IncludeNodeIds parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The name of the manual workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workflow</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The IDs of specific nodes to run within the manual workflow. Separate multiple node IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>The node parameter information passed when the manual workflow is executed. This corresponds to the <b>scheduling parameters</b> configured in the <b>Properties</b> of nodes within the manual workflow.</para>
        /// <para>A JSON format: { &quot;<Node ID within the manual workflow>&quot;: &quot;Scheduling parameter information of the node, in the same format as the parameters in the data development scheduling configuration&quot;, &quot;<Node ID within the manual workflow>&quot;: &quot;Scheduling parameter information of the node, in the same format as the parameters in the data development scheduling configuration&quot; }</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;20000123121&quot;: &quot;key1=val2 key2=val2&quot;, &quot;20000123124&quot;: &quot;kkkk=vvvvv aaaa=bbbb&quot;}</para>
        /// </summary>
        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        /// <summary>
        /// <para>The environment identifier of the Operation Center. PROD indicates the production environment. DEV indicates the development environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD or DEV</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the manual workflow belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_workspace</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The business start date. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is used together with the EndBizDate parameter. You can configure only one of the StartBizDate and EndBizDate pair or the BizDate parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

    }

}
