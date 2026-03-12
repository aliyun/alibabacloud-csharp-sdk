// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeConfigHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeConfigHistoryResponseBodyData> Data { get; set; }
        public class DescribeConfigHistoryResponseBodyData : TeaModel {
            [NameInMap("ConfigHistoryEffectDetails")]
            [Validation(Required=false)]
            public List<DescribeConfigHistoryResponseBodyDataConfigHistoryEffectDetails> ConfigHistoryEffectDetails { get; set; }
            public class DescribeConfigHistoryResponseBodyDataConfigHistoryEffectDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>effective</para>
                /// </summary>
                [NameInMap("EffectStatus")]
                [Validation(Required=false)]
                public string EffectStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ng-e6e15d2cdefdb38c</para>
                /// </summary>
                [NameInMap("NodeGroupId")]
                [Validation(Required=false)]
                public string NodeGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000367486</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6838</para>
            /// </summary>
            [NameInMap("ConfigHistoryId")]
            [Validation(Required=false)]
            public string ConfigHistoryId { get; set; }

            [NameInMap("ConfigMementos")]
            [Validation(Required=false)]
            public List<DescribeConfigHistoryResponseBodyDataConfigMementos> ConfigMementos { get; set; }
            public class DescribeConfigHistoryResponseBodyDataConfigMementos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MODIFY</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("After")]
                [Validation(Required=false)]
                public string After { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Before")]
                [Validation(Required=false)]
                public string Before { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>create_tablet_worker_count</para>
                /// </summary>
                [NameInMap("ConfigKey")]
                [Validation(Required=false)]
                public string ConfigKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FE</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>effective</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public string EffectStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Effected")]
            [Validation(Required=false)]
            public bool? Effected { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1742178604000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>149920818483****</para>
            /// </summary>
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Test.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public bool? Rollback { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
