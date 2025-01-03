// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreatePushRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreatePushRuleResponseBodyResult Result { get; set; }
        public class CreatePushRuleResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-09-03T18:20:06+08:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-09-03T18:20:06+08:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2077</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ruleInfos")]
            [Validation(Required=false)]
            public List<CreatePushRuleResponseBodyResultRuleInfos> RuleInfos { get; set; }
            public class CreatePushRuleResponseBodyResultRuleInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ForcePushChecker</para>
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
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("extraMessage")]
                [Validation(Required=false)]
                public string ExtraMessage { get; set; }

                [NameInMap("fileRuleRegexes")]
                [Validation(Required=false)]
                public List<string> FileRuleRegexes { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
