// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreatePipelineRunShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The code of the stage to which the deployment process runs. This parameter takes effect only when the RunMode parameter is set to Auto. After the deployment process is created, it automatically runs to the specified stage.</para>
        /// <remarks>
        /// <para>Notice: The specified stage is automatically completed. For example, if you set this parameter to DEV, the automatic running stops after the DEV stage reaches the desired state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("AutoRunUntilStage")]
        [Validation(Required=false)]
        public string AutoRunUntilStage { get; set; }

        /// <summary>
        /// <para>The description of the deployment process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a OdpsSQL-node publishing process. The function is XXXX.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of entity IDs to be deployed in this deployment process.</para>
        /// <remarks>
        /// <para>Notice: Currently, only a single entity and its child entities can be deployed. Therefore, only the first entity and its child entities in the array are deployed. Make sure that the array contains only one element. Additional elements are ignored.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectIds")]
        [Validation(Required=false)]
        public string ObjectIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Configuration page to obtain the workspace ID.
        /// This parameter specifies the DataWorks workspace on which the API operation is performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The running mode of the deployment process. Default value: Normal. If you set this parameter to Auto, the deployment process automatically runs to the specified stage. This parameter must be used together with the AutoRunUntilStage parameter.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal</description></item>
        /// <item><description>Auto</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <para>Specifies the type of the deployment process.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Online: Goes online.</description></item>
        /// <item><description>Offline: Goes offline.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
