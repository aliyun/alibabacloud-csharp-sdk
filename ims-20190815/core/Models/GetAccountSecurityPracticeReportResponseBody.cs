// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccountSecurityPracticeReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the security report for the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("AccountSecurityPracticeInfo")]
        [Validation(Required=false)]
        public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo AccountSecurityPracticeInfo { get; set; }
        public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfo : TeaModel {
            /// <summary>
            /// <para>The information about the security report for the Alibaba Cloud account.</para>
            /// </summary>
            [NameInMap("AccountSecurityPracticeUserInfo")]
            [Validation(Required=false)]
            public GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo AccountSecurityPracticeUserInfo { get; set; }
            public class GetAccountSecurityPracticeReportResponseBodyAccountSecurityPracticeInfoAccountSecurityPracticeUserInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether multi-factor authentication (MFA) is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BindMfa")]
                [Validation(Required=false)]
                public bool? BindMfa { get; set; }

                /// <summary>
                /// <para>The number of old AccessKey pairs for the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OldAkNum")]
                [Validation(Required=false)]
                public int? OldAkNum { get; set; }

                /// <summary>
                /// <para>The number of AccessKey pairs for the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RootWithAccessKey")]
                [Validation(Required=false)]
                public int? RootWithAccessKey { get; set; }

                /// <summary>
                /// <para>The number of RAM users within the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("SubUser")]
                [Validation(Required=false)]
                public int? SubUser { get; set; }

                /// <summary>
                /// <para>The number of RAM users that have MFA devices bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubUserBindMfa")]
                [Validation(Required=false)]
                public int? SubUserBindMfa { get; set; }

                /// <summary>
                /// <para>The complexity level of the password for the RAM user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>low</description></item>
                /// <item><description>mid</description></item>
                /// <item><description>high</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>low</para>
                /// </summary>
                [NameInMap("SubUserPwdLevel")]
                [Validation(Required=false)]
                public string SubUserPwdLevel { get; set; }

                /// <summary>
                /// <para>The number of RAM users that use the old AccessKey pairs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubUserWithOldAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithOldAccessKey { get; set; }

                /// <summary>
                /// <para>The number of Resource Access Management (RAM) users that have unused AccessKey pairs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubUserWithUnusedAccessKey")]
                [Validation(Required=false)]
                public int? SubUserWithUnusedAccessKey { get; set; }

                /// <summary>
                /// <para>The number of AccessKey pairs that are not used for the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAkNum")]
                [Validation(Required=false)]
                public int? UnusedAkNum { get; set; }

            }

            /// <summary>
            /// <para>The security score of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABA822EE-85C2-4418-9577-A1831FC8466D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
