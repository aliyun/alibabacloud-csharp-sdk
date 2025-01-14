// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateBootAndAntiUninstallPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public bool? AllowReport { get; set; }

        [NameInMap("BlockContent")]
        [Validation(Required=false)]
        public UpdateBootAndAntiUninstallPolicyRequestBlockContent BlockContent { get; set; }
        public class UpdateBootAndAntiUninstallPolicyRequestBlockContent : TeaModel {
            [NameInMap("BlockTextEn")]
            [Validation(Required=false)]
            public UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextEn BlockTextEn { get; set; }
            public class UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextEn : TeaModel {
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
            public UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextZh BlockTextZh { get; set; }
            public class UpdateBootAndAntiUninstallPolicyRequestBlockContentBlockTextZh : TeaModel {
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

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        [NameInMap("WhitelistUsers")]
        [Validation(Required=false)]
        public List<string> WhitelistUsers { get; set; }

    }

}
