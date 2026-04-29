// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetAsrResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudGetAsrResponseBodyData Data { get; set; }
        public class CloudGetAsrResponseBodyData : TeaModel {
            /// <summary>
            /// <para>企业编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>7000002</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public string EnterpriseId { get; set; }

            /// <summary>
            /// <para>转写类型 1：混音 2：分轨</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            /// <summary>
            /// <para>转写文件个数</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecordFileCount")]
            [Validation(Required=false)]
            public string RecordFileCount { get; set; }

            /// <summary>
            /// <para>第一侧转写文本结果</para>
            /// </summary>
            [NameInMap("RecordFileText1In")]
            [Validation(Required=false)]
            public CloudGetAsrResponseBodyDataRecordFileText1In RecordFileText1In { get; set; }
            public class CloudGetAsrResponseBodyDataRecordFileText1In : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>33340</para>
                /// </summary>
                [NameInMap("BizDuration")]
                [Validation(Required=false)]
                public long? BizDuration { get; set; }

                /// <summary>
                /// <para>错误信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>8f2ff56a7cfe458c942595b2f271d715</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>转写结果</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<CloudGetAsrResponseBodyDataRecordFileText1InResult> Result { get; set; }
                public class CloudGetAsrResponseBodyDataRecordFileText1InResult : TeaModel {
                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30140</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public long? BeginTime { get; set; }

                    /// <summary>
                    /// <para>通道id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public long? ChannelId { get; set; }

                    /// <summary>
                    /// <para>情感值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.0</para>
                    /// </summary>
                    [NameInMap("EmotionValue")]
                    [Validation(Required=false)]
                    public double? EmotionValue { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>31805</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>沉默时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SilenceDuration")]
                    [Validation(Required=false)]
                    public long? SilenceDuration { get; set; }

                    /// <summary>
                    /// <para>语速</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>108</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public long? SpeechRate { get; set; }

                    /// <summary>
                    /// <para>转写文本</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>状态码</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>第二侧转写文本结果</para>
            /// </summary>
            [NameInMap("RecordFileText1Out")]
            [Validation(Required=false)]
            public CloudGetAsrResponseBodyDataRecordFileText1Out RecordFileText1Out { get; set; }
            public class CloudGetAsrResponseBodyDataRecordFileText1Out : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>33340</para>
                /// </summary>
                [NameInMap("BizDuration")]
                [Validation(Required=false)]
                public long? BizDuration { get; set; }

                /// <summary>
                /// <para>错误信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>145a13227e3249258cd3b5232a56d634</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>转写结果</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<CloudGetAsrResponseBodyDataRecordFileText1OutResult> Result { get; set; }
                public class CloudGetAsrResponseBodyDataRecordFileText1OutResult : TeaModel {
                    /// <summary>
                    /// <para>开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30550</para>
                    /// </summary>
                    [NameInMap("BeginTime")]
                    [Validation(Required=false)]
                    public long? BeginTime { get; set; }

                    /// <summary>
                    /// <para>通道id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ChannelId")]
                    [Validation(Required=false)]
                    public long? ChannelId { get; set; }

                    /// <summary>
                    /// <para>情感值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.0</para>
                    /// </summary>
                    [NameInMap("EmotionValue")]
                    [Validation(Required=false)]
                    public double? EmotionValue { get; set; }

                    /// <summary>
                    /// <para>结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>31515</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <para>沉默时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SilenceDuration")]
                    [Validation(Required=false)]
                    public long? SilenceDuration { get; set; }

                    /// <summary>
                    /// <para>语速</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>186</para>
                    /// </summary>
                    [NameInMap("SpeechRate")]
                    [Validation(Required=false)]
                    public long? SpeechRate { get; set; }

                    /// <summary>
                    /// <para>转写文本</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                /// <summary>
                /// <para>状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>状态码</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public long? StatusCode { get; set; }

            }

            /// <summary>
            /// <para>转写结果, 当all=true时返回</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<CloudGetAsrResponseBodyDataResult> Result { get; set; }
            public class CloudGetAsrResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>4350</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>通道id</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public long? ChannelId { get; set; }

                /// <summary>
                /// <para>情感值</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.0</para>
                /// </summary>
                [NameInMap("EmotionValue")]
                [Validation(Required=false)]
                public double? EmotionValue { get; set; }

                /// <summary>
                /// <para>结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>10445</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>语音文本所属方；in: 第一侧；out: 第二侧</para>
                /// 
                /// <b>Example:</b>
                /// <para>out</para>
                /// </summary>
                [NameInMap("Side")]
                [Validation(Required=false)]
                public string Side { get; set; }

                /// <summary>
                /// <para>沉默时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SilenceDuration")]
                [Validation(Required=false)]
                public long? SilenceDuration { get; set; }

                /// <summary>
                /// <para>语速</para>
                /// 
                /// <b>Example:</b>
                /// <para>255</para>
                /// </summary>
                [NameInMap("SpeechRate")]
                [Validation(Required=false)]
                public long? SpeechRate { get; set; }

                /// <summary>
                /// <para>转写文本</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
