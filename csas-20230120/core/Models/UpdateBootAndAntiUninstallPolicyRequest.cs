// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateBootAndAntiUninstallPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Let end users submit approval requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public bool? AllowReport { get; set; }

        /// <summary>
        /// <para>Content shown in the client-side block dialog.</para>
        /// </summary>
        [NameInMap("BlockContent")]
        [Validation(Required=false)]
        public UpdateBootAndAntiUninstallPolicyRequestBlockContent BlockContent { get; set; }
        public class UpdateBootAndAntiUninstallPolicyRequestBlockContent : TeaModel {
            /// <summary>
            /// <para>English text.</para>
            /// </summary>
            [NameInMap("BlockTextEn")]
            [Validation(Required=false)]
            public UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextEn BlockTextEn { get; set; }
            public class UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextEn : TeaModel {
                /// <summary>
                /// <para>Dialog content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>After uninstalling, the device can no longer be used for company work, and it will lose access to the company\&quot;s intranet!</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Main button text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Report</para>
                /// </summary>
                [NameInMap("MainButtonText")]
                [Validation(Required=false)]
                public string MainButtonText { get; set; }

                /// <summary>
                /// <para>Secondary button text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ignore</para>
                /// </summary>
                [NameInMap("MinorButtonText")]
                [Validation(Required=false)]
                public string MinorButtonText { get; set; }

                /// <summary>
                /// <para>Dialog title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Anti-Uninstall Warning</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Chinese text.</para>
            /// </summary>
            [NameInMap("BlockTextZh")]
            [Validation(Required=false)]
            public UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextZh BlockTextZh { get; set; }
            public class UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextZh : TeaModel {
                /// <summary>
                /// <para>Dialog content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>卸载后该设备无法再用于公司办公，同时该设备将失去进入公司内网权限！</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Main button text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>去报备</para>
                /// </summary>
                [NameInMap("MainButtonText")]
                [Validation(Required=false)]
                public string MainButtonText { get; set; }

                /// <summary>
                /// <para>Secondary button text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>我知道了</para>
                /// </summary>
                [NameInMap("MinorButtonText")]
                [Validation(Required=false)]
                public string MinorButtonText { get; set; }

                /// <summary>
                /// <para>Dialog title.</para>
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
        /// <para>Enable anti-uninstall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAntiUninstall")]
        [Validation(Required=false)]
        public bool? IsAntiUninstall { get; set; }

        /// <summary>
        /// <para>Enable auto-start.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsBoot")]
        [Validation(Required=false)]
        public bool? IsBoot { get; set; }

        /// <summary>
        /// <para>List of user group IDs to which this policy applies.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>List of whitelisted users.</para>
        /// </summary>
        [NameInMap("WhitelistUsers")]
        [Validation(Required=false)]
        public List<string> WhitelistUsers { get; set; }

    }

}
