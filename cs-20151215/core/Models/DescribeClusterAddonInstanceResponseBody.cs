// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NetworkPolicy&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The name of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terway-eniip</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The status of the component. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>initial: the component is being installed.</description></item>
        /// <item><description>active: the component is installed.</description></item>
        /// <item><description>unhealthy: the component abnormal.</description></item>
        /// <item><description>upgrading: the component is being updated.</description></item>
        /// <item><description>updating: the component is being modified.</description></item>
        /// <item><description>deleting: the component is being uninstalled.</description></item>
        /// <item><description>deleted: The component is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The version of the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.4.3</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
