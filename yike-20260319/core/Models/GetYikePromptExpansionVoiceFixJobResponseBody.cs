// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class GetYikePromptExpansionVoiceFixJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The error code. This parameter is returned when the task is in the Failed state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82df****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The task parameters, in JSON format. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description>model (String, required): The model name. Example: happyhorse-1.0-r2v.</description></item>
        /// <item><description>input (Object, required): The input data object.<list type="bullet">
        /// <item><description>prompt (String, required): The prompt content. The maximum length is 10,000 characters.</description></item>
        /// <item><description>media (Array(Object), required): The list of media materials used to specify reference images and audio.<list type="bullet">
        /// <item><description>type (String, required): The input media type. Valid values: reference_image and reference_audio.</description></item>
        /// <item><description>url (String, required): The URL of the input media.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>parameters (Object, required): The video generation parameter object.<list type="bullet">
        /// <item><description>duration (Integer, required): The video duration in seconds. The value must be a positive integer. Valid values: 5 to 15.</description></item>
        /// <item><description>ratio (String, required): The aspect ratio. Valid values: 16:9, 9:16, 4:3, 3:4, and 1:1.</description></item>
        /// <item><description>resolution (String, required): The video resolution. Valid values: 720P and 1080P.</description></item>
        /// <item><description>specialEdition (Bool, optional): The cost-effective edition parameter. This parameter can be set to true only when the resolution is 1080P.</description></item>
        /// <item><description>skipPromptEnhancer (Bool, optional): Specifies whether to skip prompt enhancement. Default value: false.</description></item>
        /// <item><description>skipVoiceResync (Bool, optional): Specifies whether to skip audio repair. Default value: false.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;model\&quot;:\&quot;happyhorse-1.0-r2v\&quot;,\&quot;input\&quot;:{\&quot;prompt\&quot;:\&quot;[Image 1]中身着红色旗袍的女性，镜头先以侧面中景勾勒旗袍修身剪裁与S型曲线，随即切换至低角度仰拍，捕捉她轻抬玉手展开[Image 2]中的折扇的同时，[Image 3]中的流苏耳坠随头部转动轻盈摆动的细节，最后推近至面部特写，定格在她指尖轻点扇骨、眼波流转间的含蓄风情，多视角全方位展现东方韵味。\&quot;,\&quot;media\&quot;:[{\&quot;type\&quot;:\&quot;reference_image\&quot;,\&quot;url\&quot;:\&quot;<a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/mvzfud/hh-v2v-girl.jpg%5C%5C%22%7D,%7B%5C%5C%22type%5C%5C%22:%5C%5C%22reference_image%5C%5C%22,%5C%5C%22url%5C%5C%22:%5C%5C%22https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/fvuihk/hh-v2v2-folding-fan.jpg%5C%5C%22%7D,%7B%5C%5C%22type%5C%5C%22:%5C%5C%22reference_image%5C%5C%22,%5C%5C%22url%5C%5C%22:%5C%5C%22https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/imerii/hh-v2v-earrings.jpg%5C%5C%22%7D%5D%7D,%5C%5C%22parameters%5C%5C%22:%7B%5C%5C%22resolution%5C%5C%22:%5C%5C%22720P%5C%5C%22,%5C%5C%22ratio%5C%5C%22:%5C%5C%2216:9%5C%5C%22,%5C%5C%22duration%5C%5C%22:5,%5C%5C%22specialEdition%5C%5C%22:false,%5C%5C%22skipPromptEnhancer%5C%5C%22:false,%5C%5C%22skipVoiceResync%5C%5C%22:false%7D%7D">https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/mvzfud/hh-v2v-girl.jpg\\&quot;},{\\&quot;type\\&quot;:\\&quot;reference_image\\&quot;,\\&quot;url\\&quot;:\\&quot;https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/fvuihk/hh-v2v2-folding-fan.jpg\\&quot;},{\\&quot;type\\&quot;:\\&quot;reference_image\\&quot;,\\&quot;url\\&quot;:\\&quot;https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/imerii/hh-v2v-earrings.jpg\\&quot;}]},\\&quot;parameters\\&quot;:{\\&quot;resolution\\&quot;:\\&quot;720P\\&quot;,\\&quot;ratio\\&quot;:\\&quot;16:9\\&quot;,\\&quot;duration\\&quot;:5,\\&quot;specialEdition\\&quot;:false,\\&quot;skipPromptEnhancer\\&quot;:false,\\&quot;skipVoiceResync\\&quot;:false}}</a></para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The task result of the node.</para>
        /// </summary>
        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public List<GetYikePromptExpansionVoiceFixJobResponseBodyJobResult> JobResult { get; set; }
        public class GetYikePromptExpansionVoiceFixJobResponseBodyJobResult : TeaModel {
            /// <summary>
            /// <para>Oss Url</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/test.mp4">https://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

        }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Succeeded</b>: The task is processed.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: The task failed.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The task is being processed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        /// <summary>
        /// <para>RequestId</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-24T00:55:06Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The custom user parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testKey&quot;:&quot;testValue&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
