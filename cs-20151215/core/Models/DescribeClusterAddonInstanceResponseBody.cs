// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the add-on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NetworkPolicy&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The name of the add-on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>terway-eniip</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The state of the add-on. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>initial: The add-on is being installed.</description></item>
        /// <item><description>active: The add-on is installed.</description></item>
        /// <item><description>unhealthy: The add-on is in an abnormal state.</description></item>
        /// <item><description>upgrading: The add-on is being upgraded.</description></item>
        /// <item><description>updating: The add-on is being updated.</description></item>
        /// <item><description>deleting: The add-on is being uninstalled.</description></item>
        /// <item><description>deleted: The add-on is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The version of the add-on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.4.3</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
