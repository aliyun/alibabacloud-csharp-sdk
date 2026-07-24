// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckFreezeResultResponseBody : TeaModel {
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
        /// <para>The data on the current page.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetOssCheckFreezeResultResponseBodyItems> Items { get; set; }
        public class GetOssCheckFreezeResultResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmp</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The error code, which is consistent with the HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The audio or video scan type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The primary service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio_media_detection</para>
            /// </summary>
            [NameInMap("CopyFrom")]
            [Validation(Required=false)]
            public string CopyFrom { get; set; }

            /// <summary>
            /// <para>The feedback. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>misreport: False positive (not a violation).</description></item>
            /// <item><description>missOut: Missed violation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>misreport</para>
            /// </summary>
            [NameInMap("Feedback")]
            [Validation(Required=false)]
            public string Feedback { get; set; }

            /// <summary>
            /// <para>Indicates whether the object is frozen.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Freeze")]
            [Validation(Required=false)]
            public bool? Freeze { get; set; }

            /// <summary>
            /// <para>The freeze status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZED</para>
            /// </summary>
            [NameInMap("FreezeStatus")]
            [Validation(Required=false)]
            public string FreezeStatus { get; set; }

            /// <summary>
            /// <para>The freeze type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACL</para>
            /// </summary>
            [NameInMap("FreezeType")]
            [Validation(Required=false)]
            public string FreezeType { get; set; }

            /// <summary>
            /// <para>The URL of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyuncs.com/test.jpg">http://www.aliyuncs.com/test.jpg</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is copied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCopy")]
            [Validation(Required=false)]
            public bool? IsCopy { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dhT20X2310</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The label details.</para>
            /// </summary>
            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<GetOssCheckFreezeResultResponseBodyItemsLabelDetails> LabelDetails { get; set; }
            public class GetOssCheckFreezeResultResponseBodyItemsLabelDetails : TeaModel {
                /// <summary>
                /// <para>The confidence level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                /// <summary>
                /// <para>The label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>涉政</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The label details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>politics</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <para>The image labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The text labels.</para>
            /// </summary>
            [NameInMap("Labels2")]
            [Validation(Required=false)]
            public List<string> Labels2 { get; set; }

            /// <summary>
            /// <para>The manual action status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FREEZE: Frozen.</description></item>
            /// <item><description>UNFREEZE: Unfrozen.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZE</para>
            /// </summary>
            [NameInMap("ManualFreezeAction")]
            [Validation(Required=false)]
            public string ManualFreezeAction { get; set; }

            /// <summary>
            /// <para>The action time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-09 12:00:00</para>
            /// </summary>
            [NameInMap("ManualOperateTime")]
            [Validation(Required=false)]
            public string ManualOperateTime { get; set; }

            /// <summary>
            /// <para>The operator who performed the action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ManualOperator")]
            [Validation(Required=false)]
            public string ManualOperator { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54416c9b159df4a60ae03c04ccb94cb5</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>The detailed description of the error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The object name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713014531569_958.png.jpeg</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F0A594BB-FA7A-580F-AE9E-A4188E092823</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The image risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The overall risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel0")]
            [Validation(Required=false)]
            public string RiskLevel0 { get; set; }

            /// <summary>
            /// <para>The text risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("RiskLevel2")]
            [Validation(Required=false)]
            public string RiskLevel2 { get; set; }

            /// <summary>
            /// <para>The scan result details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScanResult")]
            [Validation(Required=false)]
            public string ScanResult { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audio_media_detection_01</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务名称</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The system action status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FREEZING: Freezing in progress.</description></item>
            /// <item><description>FREEZED: Frozen.</description></item>
            /// <item><description>UNFREEZED: Unfrozen.</description></item>
            /// <item><description>NONE: No action taken.</description></item>
            /// <item><description>UNFREEZING: Unfreezing in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FREEZED</para>
            /// </summary>
            [NameInMap("SysDisposalStatus")]
            [Validation(Required=false)]
            public string SysDisposalStatus { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P_BT3FHS</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyuncs.com/test.mp3">http://www.aliyuncs.com/test.mp3</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0A594BB-FA7A-580F-AE9E-A4188E092823</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
