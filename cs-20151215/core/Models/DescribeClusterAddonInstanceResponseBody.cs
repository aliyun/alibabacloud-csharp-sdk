// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The component configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NetworkPolicy&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The component name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terway-eniip</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The component status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>initial: installing</description></item>
        /// <item><description>active: installed</description></item>
        /// <item><description>unhealthy: abnormal</description></item>
        /// <item><description>upgrading: upgrading</description></item>
        /// <item><description>updating: updating</description></item>
        /// <item><description>deleting: uninstalling</description></item>
        /// <item><description>deleted: deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The component version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.4.3</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
