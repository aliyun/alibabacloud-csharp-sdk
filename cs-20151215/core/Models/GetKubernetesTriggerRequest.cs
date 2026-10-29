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
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>deployment</c>: The trigger for stateless applications.</description></item>
        /// <item><description><c>application</c>: The trigger for application center applications.
        /// Default value: <c>deployment</c>.
        /// If the trigger type is not specified, the query results are not filtered by trigger type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>deployment</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The trigger action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>redeploy</c>: Redeploys the resources defined in <c>project_id</c>.
        /// If the trigger action is not specified, the query results are not filtered by trigger action.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>redeploy</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
