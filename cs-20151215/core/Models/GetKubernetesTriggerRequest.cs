// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetKubernetesTriggerRequest : Darabonba.Model {
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
        /// <item><description><c>deployment</c>: the trigger for stateless applications.</description></item>
        /// <item><description><c>application</c>: the trigger for Application Center applications.
        /// Default value: <c>deployment</c>.
        /// If you do not specify the trigger type, the query results are not filtered by trigger type.</description></item>
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
        /// If you do not specify the trigger action, the query results are not filtered by trigger action.</description></item>
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

