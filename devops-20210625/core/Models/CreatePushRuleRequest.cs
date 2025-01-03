// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreatePushRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ruleInfos")]
        [Validation(Required=false)]
        public List<CreatePushRuleRequestRuleInfos> RuleInfos { get; set; }
        public class CreatePushRuleRequestRuleInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CommitMessageChecker</para>
            /// </summary>
            [NameInMap("checkerName")]
            [Validation(Required=false)]
            public string CheckerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("checkerType")]
            [Validation(Required=false)]
            public string CheckerType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("extraMessage")]
            [Validation(Required=false)]
            public string ExtraMessage { get; set; }

            [NameInMap("fileRuleRegexes")]
            [Validation(Required=false)]
            public List<string> FileRuleRegexes { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ebbc0228123212b59xxxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
