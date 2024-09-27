// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetKubernetesTriggerRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web-server</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The type of trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deployment</c>: performs actions on Deployments.</description></item>
        /// <item><description><c>application</c>: performs actions on applications that are deployed in Application Center.</description></item>
        /// </list>
        /// <para>Default value: <c>deployment</c>.</para>
        /// <para>If you do not set this parameter, triggers are not filtered by type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The action that the trigger performs. Set the value to redeploy.</para>
        /// <para><c>redeploy</c>: redeploys the resources specified by <c>project_id</c>.</para>
        /// <para>If you do not specify this parameter, triggers are not filtered by action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redeploy</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
