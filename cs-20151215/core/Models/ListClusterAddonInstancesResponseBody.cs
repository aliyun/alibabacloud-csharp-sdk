// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterAddonInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of installed add-on instances.</para>
        /// </summary>
        [NameInMap("addons")]
        [Validation(Required=false)]
        public List<ListClusterAddonInstancesResponseBodyAddons> Addons { get; set; }
        public class ListClusterAddonInstancesResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The add-on name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coredns</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The add-on status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: Installed.</description></item>
            /// <item><description>updating: Modifying.</description></item>
            /// <item><description>upgrading: Upgrading.</description></item>
            /// <item><description>deleting: Uninstalling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The add-on version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.9.3.10-7dfca203-aliyun</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
