// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetCveHotfixResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. If the authorization failed, check the <c>message</c> field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCveHotfixResponseBodyData> Data { get; set; }
        public class GetCveHotfixResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The CVE ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2026-12345</para>
            /// </summary>
            [NameInMap("cveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The hotfix information for the CVE.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("hotfix")]
            [Validation(Required=false)]
            public GetCveHotfixResponseBodyDataHotfix Hotfix { get; set; }
            public class GetCveHotfixResponseBodyDataHotfix : TeaModel {
                /// <summary>
                /// <para>The hotfix description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Fixes the kernel issue corresponding to the CVE</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hotfix name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("hotfixName")]
                [Validation(Required=false)]
                public string HotfixName { get; set; }

                /// <summary>
                /// <para>The hotfix module name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kpatch_example</para>
                /// </summary>
                [NameInMap("moduleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                /// <summary>
                /// <para>The list of published packages that meet the kernel requirements.</para>
                /// </summary>
                [NameInMap("packages")]
                [Validation(Required=false)]
                public List<GetCveHotfixResponseBodyDataHotfixPackages> Packages { get; set; }
                public class GetCveHotfixResponseBodyDataHotfixPackages : TeaModel {
                    /// <summary>
                    /// <para>The architecture.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x86_64</para>
                    /// </summary>
                    [NameInMap("arch")]
                    [Validation(Required=false)]
                    public string Arch { get; set; }

                    /// <summary>
                    /// <para>The distribution. This value is null if the distribution is not registered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alinux3</para>
                    /// 
                    /// <b>if can be null:</b>
                    /// <c>true</c>
                    /// </summary>
                    [NameInMap("distro")]
                    [Validation(Required=false)]
                    public string Distro { get; set; }

                    /// <summary>
                    /// <para>The compatible full kernel version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.10.134-18.al8.x86_64</para>
                    /// </summary>
                    [NameInMap("kernelVersion")]
                    [Validation(Required=false)]
                    public string KernelVersion { get; set; }

                    /// <summary>
                    /// <para>The RPM package identifier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kernel-hotfix-example-1.0-1.x86_64</para>
                    /// </summary>
                    [NameInMap("rpmNevra")]
                    [Validation(Required=false)]
                    public string RpmNevra { get; set; }

                }

                /// <summary>
                /// <para>The hotfix version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
