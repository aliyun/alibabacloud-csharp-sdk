// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTriggerRequest : TeaModel {
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
        /// <para>The namespace to which the application belongs.</para>
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
        /// <item><description><para><c>deployment</c>: a trigger for a stateless application. </para>
        /// </description></item>
        /// <item><description><para><c>application</c>: a trigger for an application in Open Applications.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>deployment</c>.</para>
        /// <para>If you do not specify a trigger type, the query results are not filtered by trigger type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The trigger action. Valid values:</para>
        /// <para><c>redeploy</c>: redeploys the application.</para>
        /// <para>If you do not specify a trigger action, the query results are not filtered by trigger action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redeploy</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
