// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreatePipelineRunRequest : TeaModel {
        /// <summary>
        /// <para>The code of the stage in the publish process. This parameter takes effect only when RunMode is set to Auto. After the publish process is created, it automatically runs to the specified stage.</para>
        /// <remarks>
        /// <para>Notice: The specified stage is automatically completed. For example, if you set this parameter to DEV, the automatic run stops after the DEV stage reaches the desired state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEV</para>
        /// </summary>
        [NameInMap("AutoRunUntilStage")]
        [Validation(Required=false)]
        public string AutoRunUntilStage { get; set; }

        /// <summary>
        /// <para>The description of the publish process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a OdpsSQL-node publishing process. The function is XXXX.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of entity IDs that you want to publish in this publish process.</para>
        /// <remarks>
        /// <para>Notice: Only a single entity and its child entities can be published at a time. Only the first entity in this array and its child entities are published. Make sure that the length of this array is 1. Entities beyond the first one are ignored.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectIds")]
        [Validation(Required=false)]
        public List<string> ObjectIds { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.
        /// This parameter specifies the DataWorks workspace for this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The run mode of the publish process. Default value: Normal. If you set this parameter to Auto, the publish process is automatically driven to the specified stage. This parameter is used together with the AutoRunUntilStage parameter.</para>
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
        /// <para>Specifies whether the publish process is used to bring an entity online or offline.</para>
        /// <list type="bullet">
        /// <item><description><para>Online: online</para>
        /// </description></item>
        /// <item><description><para>Offline: offline</para>
        /// </description></item>
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
