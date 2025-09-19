// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAIAssetSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAIAssetSummaryResponseBodyData Data { get; set; }
        public class DescribeAIAssetSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of cloud assets with AI security posture management risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("AispmRiskAssetCnt")]
            [Validation(Required=false)]
            public int? AispmRiskAssetCnt { get; set; }

            /// <summary>
            /// <para>The number of servers on which AI components are installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EcsAssetCnt")]
            [Validation(Required=false)]
            public int? EcsAssetCnt { get; set; }

            /// <summary>
            /// <para>The number of servers that have exposed AI components.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExposedRiskAssetCnt")]
            [Validation(Required=false)]
            public int? ExposedRiskAssetCnt { get; set; }

            /// <summary>
            /// <para>The number of AI images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ImageAssetCnt")]
            [Validation(Required=false)]
            public int? ImageAssetCnt { get; set; }

            /// <summary>
            /// <para>The number of LINGJUN assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LingjunAssetCnt")]
            [Validation(Required=false)]
            public int? LingjunAssetCnt { get; set; }

            /// <summary>
            /// <para>The number of container image assets in PAI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PaiContainerCnt")]
            [Validation(Required=false)]
            public int? PaiContainerCnt { get; set; }

            /// <summary>
            /// <para>The total number of cloud asset instances in Platform for AI (PAI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("PaiInstanceCnt")]
            [Validation(Required=false)]
            public int? PaiInstanceCnt { get; set; }

            /// <summary>
            /// <para>The number of serverless assets in PAI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PaiServerlessAssetCnt")]
            [Validation(Required=false)]
            public int? PaiServerlessAssetCnt { get; set; }

            /// <summary>
            /// <para>The statistics on assets that have AI-related keys are stored in plaintext.</para>
            /// </summary>
            [NameInMap("SensitiveSummary")]
            [Validation(Required=false)]
            public DescribeAIAssetSummaryResponseBodyDataSensitiveSummary SensitiveSummary { get; set; }
            public class DescribeAIAssetSummaryResponseBodyDataSensitiveSummary : TeaModel {
                /// <summary>
                /// <para>The number of images that have AI-related keys are stored in plaintext detected by image scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ContainerImageCnt")]
                [Validation(Required=false)]
                public int? ContainerImageCnt { get; set; }

                /// <summary>
                /// <para>The number of servers that have AI-related keys are stored in plaintext detected by agentless scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EcsCnt")]
                [Validation(Required=false)]
                public int? EcsCnt { get; set; }

                /// <summary>
                /// <para>The number of images that have AI-related keys are stored in plaintext detected by agentless scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ImageCnt")]
                [Validation(Required=false)]
                public int? ImageCnt { get; set; }

                /// <summary>
                /// <para>The number of snapshots that have AI-related keys are stored in plaintext detected by agentless scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SnapshotCnt")]
                [Validation(Required=false)]
                public int? SnapshotCnt { get; set; }

                /// <summary>
                /// <para>The total number of assets that have AI-related keys are stored in plaintext.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("TotalCnt")]
                [Validation(Required=false)]
                public int? TotalCnt { get; set; }

            }

            /// <summary>
            /// <para>The number of AI snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SnapshotAssetCnt")]
            [Validation(Required=false)]
            public int? SnapshotAssetCnt { get; set; }

            /// <summary>
            /// <para>The total number of AI assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalAssetCnt")]
            [Validation(Required=false)]
            public int? TotalAssetCnt { get; set; }

            /// <summary>
            /// <para>The total number of assets with AI risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalRiskCnt")]
            [Validation(Required=false)]
            public int? TotalRiskCnt { get; set; }

            /// <summary>
            /// <para>The number of servers with AI application vulnerabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VulRiskAssetCnt")]
            [Validation(Required=false)]
            public int? VulRiskAssetCnt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
