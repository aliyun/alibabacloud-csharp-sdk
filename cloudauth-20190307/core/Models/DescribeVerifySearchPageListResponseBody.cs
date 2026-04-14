// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifySearchPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Paged list data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeVerifySearchPageListResponseBodyItems> Items { get; set; }
        public class DescribeVerifySearchPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Desensitized ID card number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3****************2</para>
            /// </summary>
            [NameInMap("CertNo")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>Authentication ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shad861465f2aaeeb805b519e1a93ab2</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            /// <summary>
            /// <para>Extended information.</para>
            /// </summary>
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public DescribeVerifySearchPageListResponseBodyItemsExtInfo ExtInfo { get; set; }
            public class DescribeVerifySearchPageListResponseBodyItemsExtInfo : TeaModel {
                /// <summary>
                /// <para>Desensitized name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>何*</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>Facial bodyguard label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOOK,ROOT</para>
                /// </summary>
                [NameInMap("DeviceRisk")]
                [Validation(Required=false)]
                public string DeviceRisk { get; set; }

                /// <summary>
                /// <para>是否是人脸攻击：</para>
                /// <list type="bullet">
                /// <item><description><b>T</b>：是</description></item>
                /// <item><description><b>F</b>：否</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>T</para>
                /// </summary>
                [NameInMap("FaceAttack")]
                [Validation(Required=false)]
                public string FaceAttack { get; set; }

                /// <summary>
                /// <para>Face attack score, ranging from 0 to 1, with values closer to 1 indicating a higher likelihood of an attack.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0000445161</para>
                /// </summary>
                [NameInMap("FaceAttackScore")]
                [Validation(Required=false)]
                public float? FaceAttackScore { get; set; }

                /// <summary>
                /// <para>Whether the face is occluded. T if occluded, otherwise F.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T</para>
                /// </summary>
                [NameInMap("FaceOcclusion")]
                [Validation(Required=false)]
                public string FaceOcclusion { get; set; }

                /// <summary>
                /// <para>Face-to-ID card comparison score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("IdCardVerifyScore")]
                [Validation(Required=false)]
                public float? IdCardVerifyScore { get; set; }

                /// <summary>
                /// <para>Photo OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-aliyun-cloudauth-XXX</para>
                /// </summary>
                [NameInMap("OssBucketName")]
                [Validation(Required=false)]
                public string OssBucketName { get; set; }

                /// <summary>
                /// <para>OCR ID card face file name.</para>
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
                /// <para>OCR ID card national emblem file name.</para>
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
                /// <para>Storage object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>verify/XXXXX1251634779/sha6a0a0cab01288c7aa8ac3f45220eb_0_normal.jpeg</para>
                /// </summary>
                [NameInMap("OssObjectName")]
                [Validation(Required=false)]
                public string OssObjectName { get; set; }

                /// <summary>
                /// <para>Liveness face quality score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("QualityScore")]
                [Validation(Required=false)]
                public float? QualityScore { get; set; }

                /// <summary>
                /// <para>Face comparison score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("VerifyScore")]
                [Validation(Required=false)]
                public float? VerifyScore { get; set; }

                /// <summary>
                /// <para>ASR text list.</para>
                /// </summary>
                [NameInMap("asrTexts")]
                [Validation(Required=false)]
                public List<string> AsrTexts { get; set; }

                /// <summary>
                /// <para>Screen recording file OSS name list.</para>
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
                /// <para>Audio file OSS name list.</para>
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
            /// <para>Verification time for this authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-14 15:40:13</para>
            /// </summary>
            [NameInMap("GmtVerify")]
            [Validation(Required=false)]
            public string GmtVerify { get; set; }

            /// <summary>
            /// <para>Liveness detection scheme.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MULTI_ACTION</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>Unique identifier for the customer request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
            /// </summary>
            [NameInMap("OuterOrderNo")]
            [Validation(Required=false)]
            public string OuterOrderNo { get; set; }

            /// <summary>
            /// <para>Whether the authentication passed. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>T</b>: Passed.</description></item>
            /// <item><description><b>F</b>: Not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>T</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>Product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>Business scenario risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk</description></item>
            /// <item><description><b>1</b>: Risk present</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskBizScenario")]
            [Validation(Required=false)]
            public int? RiskBizScenario { get; set; }

            /// <summary>
            /// <para>Device risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk</description></item>
            /// <item><description><b>1</b>: Risk present</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskDevice")]
            [Validation(Required=false)]
            public int? RiskDevice { get; set; }

            /// <summary>
            /// <para>DeviceToken risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk</description></item>
            /// <item><description><b>1</b>: Risk present</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RiskDeviceToken")]
            [Validation(Required=false)]
            public int? RiskDeviceToken { get; set; }

            /// <summary>
            /// <para>General risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk</description></item>
            /// <item><description><b>1</b>: Risk present</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskGeneric")]
            [Validation(Required=false)]
            public int? RiskGeneric { get; set; }

            /// <summary>
            /// <para>Large model mining risk:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No risk</description></item>
            /// <item><description><b>1</b>: Risk present</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskModelMining")]
            [Validation(Required=false)]
            public int? RiskModelMining { get; set; }

            /// <summary>
            /// <para>Whether it is root (pass 1 if selected, otherwise do not pass; corresponds to identity label risk type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Root")]
            [Validation(Required=false)]
            public int? Root { get; set; }

            /// <summary>
            /// <para>Scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000015352</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Whether it is a simulator (pass 1 if selected, otherwise do not pass; corresponds to device label risk type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Simulator")]
            [Validation(Required=false)]
            public int? Simulator { get; set; }

            /// <summary>
            /// <para>System returned error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>207</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198123xxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Whether it is virtual adaptation (pass 1 if selected, otherwise do not pass; corresponds to behavior label risk type).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VirtualVideo")]
            [Validation(Required=false)]
            public int? VirtualVideo { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47D87BC1-D956-573A-8A15-A9007A76F56C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
