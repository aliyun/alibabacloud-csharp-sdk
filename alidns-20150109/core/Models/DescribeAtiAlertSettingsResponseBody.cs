// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiAlertSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when the RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeAtiAlertSettingsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeAtiAlertSettingsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UpdateRspDomainServerProhibitStatusForGatewayOte</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the authorization principal owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: explicit deny.</description></item>
            /// <item><description>ImplicitDeny: implicit deny.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeAtiAlertSettingsResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeAtiAlertSettingsResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeAtiAlertSettingsResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeAtiAlertSettingsResponseBodyAlertConfigAlertConfig : TeaModel {
                [NameInMap("DingtalkNotice")]
                [Validation(Required=false)]
                public bool? DingtalkNotice { get; set; }

                [NameInMap("EmailNotice")]
                [Validation(Required=false)]
                public bool? EmailNotice { get; set; }

                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                [NameInMap("SmsNotice")]
                [Validation(Required=false)]
                public bool? SmsNotice { get; set; }

            }

        }

        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public DescribeAtiAlertSettingsResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeAtiAlertSettingsResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29D0F8F8-5499-4F6C-9FDC-1EE13BF55925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
