// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class UpdateWorkflowDagRequest : TeaModel {
        /// <summary>
        /// <para>The directed acyclic graph (DAG) of the workflow, including the information about the nodes and the edges. Specify the value of this parameter in the JSON format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodes&quot;:[{&quot;id&quot;:2300691},{&quot;id&quot;:10518089},{&quot;id&quot;:1758851}],&quot;edges&quot;:[{&quot;source&quot;:10518089,&quot;target&quot;:1758851},{&quot;source&quot;:10518089,&quot;target&quot;:2300691}]}</para>
        /// </summary>
        [NameInMap("DagJson")]
        [Validation(Required=false)]
        public string DagJson { get; set; }

        /// <summary>
        /// <para>The application group ID. You can obtain the application group ID on the Application Management page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the namespace. This parameter is required only for a special third party.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
