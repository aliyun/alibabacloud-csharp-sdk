// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeConfigHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeConfigHistoryResponseBodyData> Data { get; set; }
        public class DescribeConfigHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details about the effect of the configuration change.</para>
            /// </summary>
            [NameInMap("ConfigHistoryEffectDetails")]
            [Validation(Required=false)]
            public List<DescribeConfigHistoryResponseBodyDataConfigHistoryEffectDetails> ConfigHistoryEffectDetails { get; set; }
            public class DescribeConfigHistoryResponseBodyDataConfigHistoryEffectDetails : TeaModel {
                /// <summary>
                /// <para>The effective status on the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>effective</para>
                /// </summary>
                [NameInMap("EffectStatus")]
                [Validation(Required=false)]
                public string EffectStatus { get; set; }

                /// <summary>
                /// <para>The compute group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ng-e6e15d2cdefdb38c</para>
                /// </summary>
                [NameInMap("NodeGroupId")]
                [Validation(Required=false)]
                public string NodeGroupId { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000367486</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            /// <summary>
            /// <para>The configuration history ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6838</para>
            /// </summary>
            [NameInMap("ConfigHistoryId")]
            [Validation(Required=false)]
            public string ConfigHistoryId { get; set; }

            /// <summary>
            /// <para>A list of configuration mementos.</para>
            /// </summary>
            [NameInMap("ConfigMementos")]
            [Validation(Required=false)]
            public List<DescribeConfigHistoryResponseBodyDataConfigMementos> ConfigMementos { get; set; }
            public class DescribeConfigHistoryResponseBodyDataConfigMementos : TeaModel {
                /// <summary>
                /// <para>The action performed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>MODIFY</c></para>
                /// </description></item>
                /// <item><description><para><c>ADD</c></para>
                /// </description></item>
                /// <item><description><para><c>DELETE</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MODIFY</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The new value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("After")]
                [Validation(Required=false)]
                public string After { get; set; }

                /// <summary>
                /// <para>The previous value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Before")]
                [Validation(Required=false)]
                public string Before { get; set; }

                /// <summary>
                /// <para>The name of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_tablet_worker_count</para>
                /// </summary>
                [NameInMap("ConfigKey")]
                [Validation(Required=false)]
                public string ConfigKey { get; set; }

                /// <summary>
                /// <para>The configuration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>FE</c></para>
                /// </description></item>
                /// <item><description><para><c>BE</c></para>
                /// </description></item>
                /// <item><description><para><c>core-site.xml</c></para>
                /// </description></item>
                /// <item><description><para><c>hdfs-site.xml</c></para>
                /// </description></item>
                /// <item><description><para><c>kerberos.keytab</c></para>
                /// </description></item>
                /// <item><description><para><c>krb5.conf</c></para>
                /// </description></item>
                /// <item><description><para><c>jindosdk.cfg</c></para>
                /// </description></item>
                /// <item><description><para><c>hadoop-env.sh</c></para>
                /// </description></item>
                /// <item><description><para><c>hive-site.xml</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FE</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

            }

            /// <summary>
            /// <para>The effective status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>effective</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public string EffectStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration modification has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Effected")]
            [Validation(Required=false)]
            public bool? Effected { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742178604000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The ID of the user who modified the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149920818483****</para>
            /// </summary>
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <para>The reason for the configuration modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Indicates whether the change was a rollback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public bool? Rollback { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
