// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateKubernetesTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The action that the trigger performs. Set the value to redeploy.</para>
        /// <para><c>redeploy</c>: redeploys the resources specified by <c>project_id</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redeploy</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5cdf7e3938bc4f8eb0e44b21a80f****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the trigger project.</para>
        /// <para>The name consists of the namespace where the application is deployed and the name of the application. The format is <c>${namespace}/${name}</c>.</para>
        /// <para>Example: <c>default/test-app</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/test-app</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The type of trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deployment</c>: performs actions on Deployments.</description></item>
        /// <item><description><c>application</c>: performs actions on applications that are deployed in Application Center.</description></item>
        /// </list>
        /// <para>Default value: <c>deployment</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
