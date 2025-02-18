// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDeploymentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a OdpsSQL-node publishing process. The function is XXXX.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of entities to which you want to apply the process.</para>
        /// <remarks>
        /// <para> A process can be applied to only a single entity and its child entities. If you specify multiple entities in the array, the process is applied only to the first entity in the array and its child entities. Make sure that the array in your request contains only one element. Extra elements will be ignored.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ObjectIds")]
        [Validation(Required=false)]
        public string ObjectIdsShrink { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Specifies whether to deploy or undeploy the entity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Online: deploys the entity.</description></item>
        /// <item><description>Offline: undeploys the entity.</description></item>
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
