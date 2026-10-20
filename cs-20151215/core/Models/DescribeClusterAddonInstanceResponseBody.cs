// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonInstanceResponseBody : Darabonba.Model {
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
        /// <item><description>initial: Installing.</description></item>
        /// <item><description>active: Installed.</description></item>
        /// <item><description>unhealthy: Unhealthy.</description></item>
        /// <item><description>upgrading: Upgrading.</description></item>
        /// <item><description>updating: Updating.</description></item>
        /// <item><description>deleting: Uninstalling.</description></item>
        /// <item><description>deleted: Deleted.</description></item>
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

