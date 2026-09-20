// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunSmokeTestRequest : TeaModel {
        /// <summary>
        /// <para>The business date.</para>
        /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>. Example: <c>2020-05-26 00:00:00</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-26 00:00:00</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_create_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the node. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain the node ID.</para>
        /// <para>Full retrieval path: first call ListProjects to obtain the ProjectId, then call ListNodes, and obtain the node ID from Data.Nodes[].NodeId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The parameters of the node. This parameter is configured as a JSON string. The key is the node ID, and the value is the actual parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bizdate=$bizdate tbods=$tbods</para>
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// <para>The environment of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROD: production environment.</description></item>
        /// <item><description>DEV: development environment.</description></item>
        /// </list>
        /// <para>Workspaces in basic mode do not have a development environment. For more information, see <a href="https://help.aliyun.com/document_detail/85772.html">Basic mode and standard mode</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
