// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpgradeClusterAddonsRequestBody> Body { get; set; }
        public class UpgradeClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// <para>The name of the component.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coredns</para>
            /// </summary>
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The custom component settings that you want to use. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CpuRequest\&quot;:\&quot;800m\&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The version to which the component can be updated. You can call the <c>DescribeClusterAddonsVersion</c> operation to query the version to which the component can be updated.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.6.7</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The update policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite</description></item>
            /// <item><description>canary</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>canary</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The current version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.6.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
