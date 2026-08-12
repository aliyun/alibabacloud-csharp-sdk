// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class GetInstanceFeatureGateResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
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
        public GetInstanceFeatureGateResponseBodyData Data { get; set; }
        public class GetInstanceFeatureGateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether the restart process can be controlled from the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConsoleControlRestart")]
            [Validation(Required=false)]
            public bool? ConsoleControlRestart { get; set; }

            /// <summary>
            /// <para>Whether materialized views can be managed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableManageMv")]
            [Validation(Required=false)]
            public bool? EnableManageMv { get; set; }

            /// <summary>
            /// <para>Whether managed security groups are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FullManagedSecurityGroup")]
            [Validation(Required=false)]
            public bool? FullManagedSecurityGroup { get; set; }

            /// <summary>
            /// <para>Whether DLF meta tokens can be mounted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MountDlfMetaToken")]
            [Validation(Required=false)]
            public bool? MountDlfMetaToken { get; set; }

            /// <summary>
            /// <para>A list of new configuration types.</para>
            /// </summary>
            [NameInMap("SupportAddConfigTypes")]
            [Validation(Required=false)]
            public List<string> SupportAddConfigTypes { get; set; }

            /// <summary>
            /// <para>Whether data backup is supported.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Supports data backup.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Does not support data backup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportBackup")]
            [Validation(Required=false)]
            public bool? SupportBackup { get; set; }

            /// <summary>
            /// <para>Whether agents can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportCreateAgent")]
            [Validation(Required=false)]
            public bool? SupportCreateAgent { get; set; }

            /// <summary>
            /// <para>Whether compute groups with specifications other than <c>standard</c> can be created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportCreateNonStandardNodeGroup")]
            [Validation(Required=false)]
            public bool? SupportCreateNonStandardNodeGroup { get; set; }

            /// <summary>
            /// <para>Whether elastic ephemeral disks are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEed")]
            [Validation(Required=false)]
            public bool? SupportEed { get; set; }

            /// <summary>
            /// <para>Whether the AI function is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEnableAi")]
            [Validation(Required=false)]
            public bool? SupportEnableAi { get; set; }

            /// <summary>
            /// <para>Whether SSL can be enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportEnableSSL")]
            [Validation(Required=false)]
            public bool? SupportEnableSSL { get; set; }

            /// <summary>
            /// <para>Whether fast restart is supported for configuration changes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportFastModeModifyConfig")]
            [Validation(Required=false)]
            public bool? SupportFastModeModifyConfig { get; set; }

            /// <summary>
            /// <para>Whether resources can be modified by using fast restart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportFastModeModifyResource")]
            [Validation(Required=false)]
            public bool? SupportFastModeModifyResource { get; set; }

            /// <summary>
            /// <para>Whether fast restart is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportFastRestart")]
            [Validation(Required=false)]
            public bool? SupportFastRestart { get; set; }

            /// <summary>
            /// <para>Whether the FE gateway is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportFeGateway")]
            [Validation(Required=false)]
            public bool? SupportFeGateway { get; set; }

            /// <summary>
            /// <para>Whether custom domain names are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportHostAlias")]
            [Validation(Required=false)]
            public bool? SupportHostAlias { get; set; }

            /// <summary>
            /// <para>Whether the time zone can be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportModifyTimezone")]
            [Validation(Required=false)]
            public bool? SupportModifyTimezone { get; set; }

            /// <summary>
            /// <para>Whether observers can be deployed across multiple availability zones (AZs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportMultiAZ")]
            [Validation(Required=false)]
            public bool? SupportMultiAZ { get; set; }

            /// <summary>
            /// <para>Whether the instance uses compute nodes (CNs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseComputeNode")]
            [Validation(Required=false)]
            public bool? UseComputeNode { get; set; }

            [NameInMap("supportCompactionService")]
            [Validation(Required=false)]
            public bool? SupportCompactionService { get; set; }

            /// <summary>
            /// <para>Whether the Compaction Service allowlist feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("supportCompactionServiceWhiteList")]
            [Validation(Required=false)]
            public bool? SupportCompactionServiceWhiteList { get; set; }

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
        /// <para>B67D142D-D54E-184F-A306-22BDC01B2XXX</para>
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
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
