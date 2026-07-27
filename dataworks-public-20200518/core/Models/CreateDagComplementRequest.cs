// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDagComplementRequest : TeaModel {
        /// <summary>
        /// <para>An optional parameter. The start time of the task. This parameter is required for hour-level scheduled tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("BizBeginTime")]
        [Validation(Required=false)]
        public string BizBeginTime { get; set; }

        /// <summary>
        /// <para>An optional parameter. The end time of the task. This parameter is required for hour-level scheduled tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23:00:00</para>
        /// </summary>
        [NameInMap("BizEndTime")]
        [Validation(Required=false)]
        public string BizEndTime { get; set; }

        /// <summary>
        /// <para>The end business date of data backfill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// <para>An optional parameter. The list of node IDs to exclude from data backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The list of node IDs to include. If you backfill data for only one node, that node must be included in includeNodeIds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A JSON string. The key is the node ID, and the value is the actual parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{74324:&quot;key1=val1 key2=val&quot;}</para>
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// <para>Specifies whether the task can be executed concurrently.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public bool? Parallelism { get; set; }

        /// <summary>
        /// <para>The environment of the workspace, including PROD and DEV.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The ID of the start node for data backfill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RootNodeId")]
        [Validation(Required=false)]
        public long? RootNodeId { get; set; }

        /// <summary>
        /// <para>The start business date of data backfill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-20 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

    }

}
