// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckResultDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code, consistent with HTTP status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Detailed data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOssCheckResultDetailResponseBodyData Data { get; set; }
        public class GetOssCheckResultDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-tmp</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>Error code, consistent with HTTP status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Audio and video detection type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>Primary service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio_media_detection</para>
            /// </summary>
            [NameInMap("CopyFrom")]
            [Validation(Required=false)]
            public string CopyFrom { get; set; }

            /// <summary>
            /// <para>Freeze status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNFREEZED</para>
            /// </summary>
            [NameInMap("FreezeStatus")]
            [Validation(Required=false)]
            public string FreezeStatus { get; set; }

            /// <summary>
            /// <para>Freeze type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COPY</para>
            /// </summary>
            [NameInMap("FreezeType")]
            [Validation(Required=false)]
            public string FreezeType { get; set; }

            /// <summary>
            /// <para>Image URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyuncs.com/test.jpg">http://www.aliyuncs.com/test.jpg</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>Whether to copy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCopy")]
            [Validation(Required=false)]
            public bool? IsCopy { get; set; }

            /// <summary>
            /// <para>Job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dhT20X2310</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>Labels.</para>
            /// </summary>
            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<GetOssCheckResultDetailResponseBodyDataLabelDetails> LabelDetails { get; set; }
            public class GetOssCheckResultDetailResponseBodyDataLabelDetails : TeaModel {
                /// <summary>
                /// <para>Confidence score, 0 to 100, retained to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>Label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>涉政</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>politics</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>Labels.</para>
            /// </summary>
            [NameInMap("LabelDetails2")]
            [Validation(Required=false)]
            public List<GetOssCheckResultDetailResponseBodyDataLabelDetails2> LabelDetails2 { get; set; }
            public class GetOssCheckResultDetailResponseBodyDataLabelDetails2 : TeaModel {
                /// <summary>
                /// <para>Confidence score, 0 to 100, retained to two decimal places.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>Label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>涉政</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>politics</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>Image labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>Text labels.</para>
            /// </summary>
            [NameInMap("Labels2")]
            [Validation(Required=false)]
            public List<string> Labels2 { get; set; }

            /// <summary>
            /// <para>Manual handling status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZE</para>
            /// </summary>
            [NameInMap("ManualFreezeAction")]
            [Validation(Required=false)]
            public string ManualFreezeAction { get; set; }

            /// <summary>
            /// <para>Handling time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-09 12:00:00</para>
            /// </summary>
            [NameInMap("ManualOperateTime")]
            [Validation(Required=false)]
            public string ManualOperateTime { get; set; }

            /// <summary>
            /// <para>Handler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ManualOperator")]
            [Validation(Required=false)]
            public string ManualOperator { get; set; }

            /// <summary>
            /// <para>File MD5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f6e2e1946f06310c8a0cc443a05819f3</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>Further description of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>Object name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1748396909030.jpg</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>Image risk level</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>Overall risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel0")]
            [Validation(Required=false)]
            public string RiskLevel0 { get; set; }

            /// <summary>
            /// <para>Text risk level</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("RiskLevel2")]
            [Validation(Required=false)]
            public string RiskLevel2 { get; set; }

            /// <summary>
            /// <para>Detailed scan results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScanResult")]
            [Validation(Required=false)]
            public string ScanResult { get; set; }

            /// <summary>
            /// <para>Detection service information</para>
            /// </summary>
            [NameInMap("ScanServiceInfos")]
            [Validation(Required=false)]
            public List<GetOssCheckResultDetailResponseBodyDataScanServiceInfos> ScanServiceInfos { get; set; }
            public class GetOssCheckResultDetailResponseBodyDataScanServiceInfos : TeaModel {
                /// <summary>
                /// <para>Main service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio_media_detection</para>
                /// </summary>
                [NameInMap("CopyFrom")]
                [Validation(Required=false)]
                public string CopyFrom { get; set; }

                /// <summary>
                /// <para>Whether to copy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsCopy")]
                [Validation(Required=false)]
                public bool? IsCopy { get; set; }

                /// <summary>
                /// <para>Service code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audio_media_detection_01</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>Service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>服务名称</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// <para>Service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio_media_detection_01</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>Service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P_Z7OLMN</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Task URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyuncs.com/test.mp3">http://www.aliyuncs.com/test.mp3</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Further description of the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Backend-assigned ID used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62E97001-1255-50A9-8E1E-4FD05473D952</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
