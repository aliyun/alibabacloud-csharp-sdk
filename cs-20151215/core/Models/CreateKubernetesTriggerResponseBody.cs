// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateKubernetesTriggerResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The action of the trigger. Example: <c>redeploy</c>: Redeployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redeploy</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5cdf7e3938bc4f8eb0e44b21a80f****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The trigger ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The project name of the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default/test-app</para>
        /// </summary>
        [NameInMap("project_id")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deployment</c>: The trigger for stateless applications. </description></item>
        /// <item><description><c>application</c>: The trigger for Hybrid Cloud Application Center applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deployment</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

