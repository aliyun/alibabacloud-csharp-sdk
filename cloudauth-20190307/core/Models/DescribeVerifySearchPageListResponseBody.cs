// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySearchPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The paginated list data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeVerifySearchPageListResponseBodyItems> Items { get; set; }
        public class DescribeVerifySearchPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The desensitized ID card number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3****************2</para>
            /// </summary>
            [NameInMap("CertNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>The certification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shad861465f2aaeeb805b519e1a93ab2</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public DescribeVerifySearchPageListResponseBodyItemsExtInfo ExtInfo { get; set; }
            public class DescribeVerifySearchPageListResponseBodyItemsExtInfo : TeaModel {
                /// <summary>
                /// <para>The desensitized name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>何*</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The Face Guard tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOOK,ROOT</para>
                /// </summary>
                [NameInMap("DeviceRisk")]
                [Validation(Required=false)]
                public string DeviceRisk { get; set; }

                /// <summary>
                /// <para>Specifies whether a face attack is detected:</para>
                /// <list type="bullet">
                /// <item><description><b>T</b>: Yes.</description></item>
                /// <item><description><b>F</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>T</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                /// <summary>
                /// <para>The face attack score. The value ranges from 0 to 1. A value closer to 1 indicates a higher likelihood of an attack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0000445161</para>
                /// </summary>
                [NameInMap("FaceAttackScore")]
                [Validation(Required=false)]
                public float? FaceAttackScore { get; set; }

                /// <summary>
                /// <para>Specifies whether the face is occluded. T indicates occlusion detected. F indicates no occlusion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T</para>
                /// </summary>
                [NameInMap("FaceOcclusion")]
                [Validation(Required=false)]
                public string FaceOcclusion { get; set; }

                /// <summary>
                /// <para>The face-to-ID card comparison score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("IdCardVerifyScore")]
                [Validation(Required=false)]
                public float? IdCardVerifyScore { get; set; }

                /// <summary>
                /// <para>The OSS bucket for photos.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-aliyun-cloudauth-XXX</para>
                /// </summary>
                [NameInMap("OssBucketName")]
                [Validation(Required=false)]
                public string OssBucketName { get; set; }

                /// <summary>
                /// <para>The file name of the OCR ID card face image.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("OssIdFaceObjectName")]
                [Validation(Required=false)]
                public string OssIdFaceObjectName { get; set; }

                /// <summary>
                /// <para>The file name of the OCR ID card national emblem image.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("OssIdNationalEmblemObjectName")]
                [Validation(Required=false)]
                public string OssIdNationalEmblemObjectName { get; set; }

                /// <summary>
                /// <para>The storage object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>verify/XXXXX1251634779/sha6a0a0cab01288c7aa8ac3f45220eb_0_normal.jpeg</para>
                /// </summary>
                [NameInMap("OssObjectName")]
                [Validation(Required=false)]
                public string OssObjectName { get; set; }

                /// <summary>
                /// <para>The liveness face quality score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("QualityScore")]
                [Validation(Required=false)]
                public float? QualityScore { get; set; }

                /// <summary>
                /// <para>The face comparison score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("VerifyScore")]
                [Validation(Required=false)]
                public float? VerifyScore { get; set; }

                /// <summary>
                /// <para>The list of ASR texts.</para>
                /// </summary>
                [NameInMap("asrTexts")]
                [Validation(Required=false)]
                public List<string> AsrTexts { get; set; }

                /// <summary>
                /// <para>The list of screen recording file OSS object names.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("screenVideoObjectNames")]
                [Validation(Required=false)]
                public List<string> ScreenVideoObjectNames { get; set; }

                /// <summary>
                /// <para>The list of audio file OSS object names.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("voiceObjectNames")]
                [Validation(Required=false)]
                public List<string> VoiceObjectNames { get; set; }

            }

            /// <summary>
            /// <para>The verification time of this authentication record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-14 15:40:13</para>
            /// </summary>
            [NameInMap("GmtVerify")]
            [Validation(Required=false)]
            public string GmtVerify { get; set; }

            /// <summary>
            /// <para>The liveness detection scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MULTI_ACTION</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The unique identifier for the customer request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
            /// </summary>
            [NameInMap("OuterOrderNo")]
            [Validation(Required=false)]
            public string OuterOrderNo { get; set; }

            /// <summary>
            /// <para>Specifies whether the authentication passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>T</b>: Passed.</description></item>
            /// <item><description><b>F</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>T</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The business scenario risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk.</description></item>
            /// <item><description><b>1</b>: Risk detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskBizScenario")]
            [Validation(Required=false)]
            public int? RiskBizScenario { get; set; }

            /// <summary>
            /// <para>The device risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk.</description></item>
            /// <item><description><b>1</b>: Risk detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskDevice")]
            [Validation(Required=false)]
            public int? RiskDevice { get; set; }

            /// <summary>
            /// <para>The DeviceToken risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk.</description></item>
            /// <item><description><b>1</b>: Risk detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskDeviceToken")]
            [Validation(Required=false)]
            public int? RiskDeviceToken { get; set; }

            /// <summary>
            /// <para>The generic risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk.</description></item>
            /// <item><description><b>1</b>: Risk detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskGeneric")]
            [Validation(Required=false)]
            public int? RiskGeneric { get; set; }

            /// <summary>
            /// <para>The large model mining risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk.</description></item>
            /// <item><description><b>1</b>: Risk detected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskModelMining")]
            [Validation(Required=false)]
            public int? RiskModelMining { get; set; }

            /// <summary>
            /// <para>Specifies whether the device is rooted. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the identity tag risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Root")]
            [Validation(Required=false)]
            public int? Root { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000015352</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Specifies whether the device is a simulator. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the device tag risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Simulator")]
            [Validation(Required=false)]
            public int? Simulator { get; set; }

            /// <summary>
            /// <para>The error code returned by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>207</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198123xxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Specifies whether virtual video is used. Set to 1 if selected; otherwise, do not pass this parameter. This parameter corresponds to the behavior tag risk type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VirtualVideo")]
            [Validation(Required=false)]
            public int? VirtualVideo { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47D87BC1-D956-573A-8A15-A9007A76F56C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
