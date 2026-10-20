// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The trigger action. Valid values:</para>
        /// <para><c>redeploy</c>: redeploys the resource defined in <c>project_id</c>.</para>
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
        /// <para>The trigger project name.</para>
        /// <para>The value consists of the namespace and application name in the format of <c>${namespace}/${name}</c>.</para>
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
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>deployment</c>: a trigger for stateless applications. </para>
        /// </description></item>
        /// <item><description><para><c>application</c>: a trigger for App Hub applications.</para>
        /// </description></item>
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
