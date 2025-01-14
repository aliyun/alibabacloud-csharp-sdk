// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetBootAndAntiUninstallPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CB67D866-1E54-5106-89DF-6D70C73E5989</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public GetBootAndAntiUninstallPolicyResponseBodyStrategy Strategy { get; set; }
        public class GetBootAndAntiUninstallPolicyResponseBodyStrategy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowReport")]
            [Validation(Required=false)]
            public bool? AllowReport { get; set; }

            [NameInMap("BlockContent")]
            [Validation(Required=false)]
            public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContent BlockContent { get; set; }
            public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContent : TeaModel {
                [NameInMap("BlockTextEn")]
                [Validation(Required=false)]
                public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextEn BlockTextEn { get; set; }
                public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextEn : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>After uninstalling, the device can no longer be used for company work, and it will lose access to the company\&quot;s intranet!</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Report</para>
                    /// </summary>
                    [NameInMap("MainButtonText")]
                    [Validation(Required=false)]
                    public string MainButtonText { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Ignore</para>
                    /// </summary>
                    [NameInMap("MinorButtonText")]
                    [Validation(Required=false)]
                    public string MinorButtonText { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Anti-Uninstall Warning</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("BlockTextZh")]
                [Validation(Required=false)]
                public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextZh BlockTextZh { get; set; }
                public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextZh : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("MainButtonText")]
                    [Validation(Required=false)]
                    public string MainButtonText { get; set; }

                    [NameInMap("MinorButtonText")]
                    [Validation(Required=false)]
                    public string MinorButtonText { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-16 10:50:05</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAntiUninstall")]
            [Validation(Required=false)]
            public bool? IsAntiUninstall { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBoot")]
            [Validation(Required=false)]
            public bool? IsBoot { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>auto-boot-anti-uninstall-6f6cbf5f6605****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-process-300abfb970cc****</para>
            /// </summary>
            [NameInMap("ReportProcessId")]
            [Validation(Required=false)]
            public string ReportProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-14 10:17:14</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            [NameInMap("WhitelistUsers")]
            [Validation(Required=false)]
            public List<string> WhitelistUsers { get; set; }

        }

    }

}
