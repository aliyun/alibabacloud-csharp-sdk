// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDockerhubImageRiskRankInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this call request, a unique identifier generated by Alibaba Cloud for the request, which can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Risk information.</para>
        /// </summary>
        [NameInMap("RiskRankInfo")]
        [Validation(Required=false)]
        public GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfo RiskRankInfo { get; set; }
        public class GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfo : TeaModel {
            /// <summary>
            /// <para>Baseline risk information.</para>
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public List<GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfoBaseline> Baseline { get; set; }
            public class GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfoBaseline : TeaModel {
                /// <summary>
                /// <para>Image digest value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f28ecca63bfaf22ead4b28b63d752a21e4d2c1de90b8549fbde880d619f3****</para>
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>Number of baseline risks in the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HcCount")]
                [Validation(Required=false)]
                public int? HcCount { get; set; }

                /// <summary>
                /// <para>ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7c5ad02865aef575387a05bb3c81b27e0d8ed1f2e3f722ea05523b72882f****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>Image size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public long? ImageSize { get; set; }

                /// <summary>
                /// <para>Name of the container image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>glz123</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>Repository namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace-01</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>Risk statistics for hosts, images, and containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;account\&quot;:0,\&quot;agentlessAll\&quot;:0,\&quot;agentlessBaseline\&quot;:0,\&quot;agentlessMalicious\&quot;:0,\&quot;agentlessSensitiveFile\&quot;:0,\&quot;agentlessVulCve\&quot;:0,\&quot;agentlessVulSca\&quot;:0,\&quot;agentlessVulSys\&quot;:0,\&quot;appNum\&quot;:0,\&quot;asapVulCount\&quot;:0,\&quot;baselineHigh\&quot;:0,\&quot;baselineLow\&quot;:0,\&quot;baselineMedium\&quot;:0,\&quot;baselineNum\&quot;:0,\&quot;cmsNum\&quot;:0,\&quot;containerAsap\&quot;:0,\&quot;containerLater\&quot;:0,\&quot;containerNntf\&quot;:0,\&quot;containerRemind\&quot;:0,\&quot;containerSerious\&quot;:0,\&quot;containerSuspicious\&quot;:0,\&quot;cveNum\&quot;:0,\&quot;emgNum\&quot;:0,\&quot;health\&quot;:0,\&quot;imageBaselineHigh\&quot;:1,\&quot;imageBaselineLow\&quot;:0,\&quot;imageBaselineMedium\&quot;:0,\&quot;imageBaselineNum\&quot;:1,\&quot;imageMaliciousFileRemind\&quot;:0,\&quot;imageMaliciousFileSerious\&quot;:0,\&quot;imageMaliciousFileSuspicious\&quot;:0,\&quot;imageVulAsap\&quot;:0,\&quot;imageVulLater\&quot;:0,\&quot;imageVulNntf\&quot;:0,\&quot;laterVulCount\&quot;:0,\&quot;newSuspicious\&quot;:0,\&quot;nntfVulCount\&quot;:0,\&quot;remindNum\&quot;:0,\&quot;scaNum\&quot;:0,\&quot;seriousNum\&quot;:0,\&quot;suspNum\&quot;:0,\&quot;suspicious\&quot;:0,\&quot;sysNum\&quot;:0,\&quot;trojan\&quot;:0,\&quot;uuid\&quot;:\&quot;009635bf00c0585e3122ab92f5449919\&quot;,\&quot;vul\&quot;:0,\&quot;weakPWNum\&quot;:0}</para>
                /// </summary>
                [NameInMap("RiskLevelDetail")]
                [Validation(Required=false)]
                public string RiskLevelDetail { get; set; }

                /// <summary>
                /// <para>Image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>machineResource</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>Uuid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5583aa03-922e-4709-a888-389f2489****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <para>Number of detected vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VulCount")]
                [Validation(Required=false)]
                public int? VulCount { get; set; }

            }

            /// <summary>
            /// <para>High-risk vulnerability risk information.</para>
            /// </summary>
            [NameInMap("VulAsap")]
            [Validation(Required=false)]
            public List<GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfoVulAsap> VulAsap { get; set; }
            public class GetDockerhubImageRiskRankInfoResponseBodyRiskRankInfoVulAsap : TeaModel {
                /// <summary>
                /// <para>Image Digest value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d97c1348e56eb52902888e6e5673623321b1f19ac45ed532c3114dc0f989****</para>
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>Number of risks in the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HcCount")]
                [Validation(Required=false)]
                public int? HcCount { get; set; }

                /// <summary>
                /// <para>Image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fabe4203a89765a2c99554040bda51eac7885a18216f4ac0be82710cff60****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>Image size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public long? ImageSize { get; set; }

                /// <summary>
                /// <para>Name of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lkl-zf-ss-ordapi-labs</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>Namespace of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace-01</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>Risk statistics for all hosts, images, and containers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;account\&quot;:0,\&quot;agentlessAll\&quot;:0,\&quot;agentlessBaseline\&quot;:0,\&quot;agentlessMalicious\&quot;:0,\&quot;agentlessSensitiveFile\&quot;:0,\&quot;agentlessVulCve\&quot;:0,\&quot;agentlessVulSca\&quot;:0,\&quot;agentlessVulSys\&quot;:0,\&quot;appNum\&quot;:0,\&quot;asapVulCount\&quot;:0,\&quot;baselineHigh\&quot;:0,\&quot;baselineLow\&quot;:0,\&quot;baselineMedium\&quot;:0,\&quot;baselineNum\&quot;:0,\&quot;cmsNum\&quot;:0,\&quot;containerAsap\&quot;:0,\&quot;containerLater\&quot;:0,\&quot;containerNntf\&quot;:0,\&quot;containerRemind\&quot;:0,\&quot;containerSerious\&quot;:0,\&quot;containerSuspicious\&quot;:0,\&quot;cveNum\&quot;:513,\&quot;emgNum\&quot;:0,\&quot;health\&quot;:0,\&quot;imageBaselineHigh\&quot;:0,\&quot;imageBaselineLow\&quot;:0,\&quot;imageBaselineMedium\&quot;:0,\&quot;imageBaselineNum\&quot;:0,\&quot;imageMaliciousFileRemind\&quot;:0,\&quot;imageMaliciousFileSerious\&quot;:0,\&quot;imageMaliciousFileSuspicious\&quot;:0,\&quot;imageVulAsap\&quot;:3,\&quot;imageVulLater\&quot;:182,\&quot;imageVulNntf\&quot;:328,\&quot;laterVulCount\&quot;:0,\&quot;newSuspicious\&quot;:0,\&quot;nntfVulCount\&quot;:0,\&quot;remindNum\&quot;:0,\&quot;scaNum\&quot;:0,\&quot;seriousNum\&quot;:0,\&quot;suspNum\&quot;:0,\&quot;suspicious\&quot;:0,\&quot;sysNum\&quot;:0,\&quot;trojan\&quot;:0,\&quot;uuid\&quot;:\&quot;44ffb29d6f66d8509598bcdfa660a21d\&quot;,\&quot;vul\&quot;:513,\&quot;weakPWNum\&quot;:0}</para>
                /// </summary>
                [NameInMap("RiskLevelDetail")]
                [Validation(Required=false)]
                public string RiskLevelDetail { get; set; }

                /// <summary>
                /// <para>Image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app:app01-ubuntu</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The identifier for this record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6636c286-8063-4c97-8508-6aaf16a8****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                /// <summary>
                /// <para>Number of vulnerabilities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("VulCount")]
                [Validation(Required=false)]
                public int? VulCount { get; set; }

            }

        }

    }

}
