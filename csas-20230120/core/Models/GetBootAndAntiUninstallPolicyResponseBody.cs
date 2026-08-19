// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetBootAndAntiUninstallPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB67D866-1E54-5106-89DF-6D70C73E5989</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The auto-start and anti-uninstall policy.</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public GetBootAndAntiUninstallPolicyResponseBodyStrategy Strategy { get; set; }
        public class GetBootAndAntiUninstallPolicyResponseBodyStrategy : TeaModel {
            /// <summary>
            /// <para>Indicates whether end users are allowed to submit approval requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowReport")]
            [Validation(Required=false)]
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The content displayed in the client interception pop-up window.</para>
            /// </summary>
            [NameInMap("BlockContent")]
            [Validation(Required=false)]
            public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContent BlockContent { get; set; }
            public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContent : TeaModel {
                /// <summary>
                /// <para>The English content.</para>
                /// </summary>
                [NameInMap("BlockTextEn")]
                [Validation(Required=false)]
                public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextEn BlockTextEn { get; set; }
                public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextEn : TeaModel {
                    /// <summary>
                    /// <para>The pop-up window content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>After uninstalling, the device can no longer be used for company work, and it will lose access to the company\&quot;s intranet!</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The text of the primary button in the pop-up window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Report</para>
                    /// </summary>
                    [NameInMap("MainButtonText")]
                    [Validation(Required=false)]
                    public string MainButtonText { get; set; }

                    /// <summary>
                    /// <para>The text of the secondary button in the pop-up window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ignore</para>
                    /// </summary>
                    [NameInMap("MinorButtonText")]
                    [Validation(Required=false)]
                    public string MinorButtonText { get; set; }

                    /// <summary>
                    /// <para>The pop-up window title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Anti-Uninstall Warning</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The Chinese content.</para>
                /// </summary>
                [NameInMap("BlockTextZh")]
                [Validation(Required=false)]
                public GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextZh BlockTextZh { get; set; }
                public class GetBootAndAntiUninstallPolicyResponseBodyStrategyBlockContentBlockTextZh : TeaModel {
                    /// <summary>
                    /// <para>The pop-up window content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>卸载后该设备无法再用于公司办公，同时该设备将失去进入公司内网权限！</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The text of the primary button in the pop-up window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>去报备</para>
                    /// </summary>
                    [NameInMap("MainButtonText")]
                    [Validation(Required=false)]
                    public string MainButtonText { get; set; }

                    /// <summary>
                    /// <para>The text of the secondary button in the pop-up window.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>我知道了</para>
                    /// </summary>
                    [NameInMap("MinorButtonText")]
                    [Validation(Required=false)]
                    public string MinorButtonText { get; set; }

                    /// <summary>
                    /// <para>The pop-up window title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>防卸载警告</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the policy was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-16 10:50:05</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the anti-uninstall feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAntiUninstall")]
            [Validation(Required=false)]
            public bool? IsAntiUninstall { get; set; }

            /// <summary>
            /// <para>Indicates whether the auto-start feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBoot")]
            [Validation(Required=false)]
            public bool? IsBoot { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto-boot-anti-uninstall-6f6cbf5f6605****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The ID of the approval process associated with the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-300abfb970cc****</para>
            /// </summary>
            [NameInMap("ReportProcessId")]
            [Validation(Required=false)]
            public string ReportProcessId { get; set; }

            /// <summary>
            /// <para>The time when the policy was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-14 10:17:14</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The list of user group IDs to which the policy applies.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The list of whitelist users.</para>
            /// </summary>
            [NameInMap("WhitelistUsers")]
            [Validation(Required=false)]
            public List<string> WhitelistUsers { get; set; }

        }

    }

}
