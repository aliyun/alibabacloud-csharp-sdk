// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAApplicationUnauthorizedAccessConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether end users are allowed to submit approval requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public bool? AllowReport { get; set; }

        /// <summary>
        /// <para>The content displayed in the client block pop-up window.</para>
        /// </summary>
        [NameInMap("BlockContent")]
        [Validation(Required=false)]
        public PAApplicationUnauthorizedAccessConfigBlockContent BlockContent { get; set; }
        public class PAApplicationUnauthorizedAccessConfigBlockContent : TeaModel {
            /// <summary>
            /// <para>The English content.</para>
            /// </summary>
            [NameInMap("BlockTextEn")]
            [Validation(Required=false)]
            public PAApplicationUnauthorizedAccessConfigBlockContentBlockTextEn BlockTextEn { get; set; }
            public class PAApplicationUnauthorizedAccessConfigBlockContentBlockTextEn : TeaModel {
                /// <summary>
                /// <para>The English prompt message on the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You do not have permission to access this system. If you need to do so, please submit a permission request.</para>
                /// </summary>
                [NameInMap("BrowserAlertContent")]
                [Validation(Required=false)]
                public string BrowserAlertContent { get; set; }

                /// <summary>
                /// <para>The English background pattern of the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/xxx.png">https://img.alicdn.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("BrowserAlertStyle")]
                [Validation(Required=false)]
                public string BrowserAlertStyle { get; set; }

                /// <summary>
                /// <para>The English title of the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No Permission Access</para>
                /// </summary>
                [NameInMap("BrowserAlertTitle")]
                [Validation(Required=false)]
                public string BrowserAlertTitle { get; set; }

                /// <summary>
                /// <para>The English text on the approval request button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Report</para>
                /// </summary>
                [NameInMap("ReportButtonText")]
                [Validation(Required=false)]
                public string ReportButtonText { get; set; }

            }

            /// <summary>
            /// <para>The Chinese content.</para>
            /// </summary>
            [NameInMap("BlockTextZh")]
            [Validation(Required=false)]
            public PAApplicationUnauthorizedAccessConfigBlockContentBlockTextZh BlockTextZh { get; set; }
            public class PAApplicationUnauthorizedAccessConfigBlockContentBlockTextZh : TeaModel {
                /// <summary>
                /// <para>The prompt message on the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You do not have permission to access this system. If you need access for work purposes, submit an access request</para>
                /// </summary>
                [NameInMap("BrowserAlertContent")]
                [Validation(Required=false)]
                public string BrowserAlertContent { get; set; }

                /// <summary>
                /// <para>The background pattern of the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/xxx.png">https://img.alicdn.com/xxx.png</a></para>
                /// </summary>
                [NameInMap("BrowserAlertStyle")]
                [Validation(Required=false)]
                public string BrowserAlertStyle { get; set; }

                /// <summary>
                /// <para>The title of the block page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Access Denied</para>
                /// </summary>
                [NameInMap("BrowserAlertTitle")]
                [Validation(Required=false)]
                public string BrowserAlertTitle { get; set; }

                /// <summary>
                /// <para>The text on the approval request button.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Request Access</para>
                /// </summary>
                [NameInMap("ReportButtonText")]
                [Validation(Required=false)]
                public string ReportButtonText { get; set; }

            }

        }

        /// <summary>
        /// <para>Specifies whether the feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. If an application is unauthorized, the user is redirected to the block page.</description></item>
        /// <item><description><b>false</b>: Disabled. If an application is unauthorized, an error message is returned by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the approval process associated with the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-0ee84ac4f9c31bc5</para>
        /// </summary>
        [NameInMap("ReportProcessId")]
        [Validation(Required=false)]
        public string ReportProcessId { get; set; }

    }

}
