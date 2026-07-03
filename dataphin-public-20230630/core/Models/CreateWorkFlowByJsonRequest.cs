// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateWorkFlowByJsonRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public CreateWorkFlowByJsonRequestContext Context { get; set; }
        public class CreateWorkFlowByJsonRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: the development environment.</description></item>
            /// <item><description>PROD: the production environment.</description></item>
            /// </list>
            /// <para>The current version supports only BASIC mode, so set this parameter to PROD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROD</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the workflow node belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>789</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The JSON script command for creating a workflow.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateWorkFlowByJsonRequestCreateCommand CreateCommand { get; set; }
        public class CreateWorkFlowByJsonRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The description of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cooment</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The folder to which the node belongs. If this parameter is left empty, the root folder is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The schedule configuration. This parameter is required for periodic nodes. The value is a JSON string. Refer to the utility class: com.alibaba.dataphin.pipeline.common.facade.openapi.model.OAScheduleConfig#toJsonString method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cronExpression&quot;:&quot;0 0 0 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public string ScheduleConfig { get; set; }

            /// <summary>
            /// <para>Specifies whether to submit the node. Default value: true.</para>
            /// </summary>
            [NameInMap("Submit")]
            [Validation(Required=false)]
            public bool? Submit { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workflow_name</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: periodic scheduling.</description></item>
            /// <item><description>3: manual scheduling.</description></item>
            /// <item><description>5: real-time node.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5372881</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

            /// <summary>
            /// <para>The workflow JSON.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;pipelineDTO&quot;:{&quot;hops&quot;:[],&quot;steps&quot;:[{&quot;name&quot;:&quot;xxx&quot;,&quot;x&quot;:305,&quot;y&quot;:144,&quot;id&quot;:&quot;c404a7c6-8a75-4ed8-b348-0785423ad859&quot;,&quot;webConfig&quot;:{},&quot;type&quot;:&quot;text&quot;,&quot;key&quot;:&quot;special_character_removal&quot;,&quot;pluginConfig&quot;:{&quot;neuronParameters&quot;:{},&quot;neuronInput&quot;:{},&quot;neuronOutput&quot;:{},&quot;setting&quot;:{}}}]}}</para>
            /// </summary>
            [NameInMap("WorkFlowJson")]
            [Validation(Required=false)]
            public string WorkFlowJson { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
