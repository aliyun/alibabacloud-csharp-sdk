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
            /// <para>The component name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>coredns</para>
            /// </summary>
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The custom parameters of the component, encoded as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CpuRequest&quot;:&quot;800m&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The target version to which you want to upgrade. You can call the <c>DescribeAddon</c> operation to query the versions to which the component can be upgraded.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.11.3.5-5321daf49-aliyun</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The component upgrade policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>overwrite: overwrites the existing version.</description></item>
            /// <item><description>canary: performs a canary upgrade.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>canary</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The current component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.11.3.2-f57ea7ed6-aliyun</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
