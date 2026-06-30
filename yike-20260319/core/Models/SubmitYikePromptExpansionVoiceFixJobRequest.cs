// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikePromptExpansionVoiceFixJobRequest : TeaModel {
        /// <summary>
        /// <para>The task parameters, a JSON-formatted string. The following fields are included:</para>
        /// <list type="bullet">
        /// <item><description>model (String, required): The model name. Example: happyhorse-1.0-r2v.</description></item>
        /// <item><description>input (Object, required): The input data object.<list type="bullet">
        /// <item><description>prompt (String, required): The prompt content. Maximum length: 10,000 characters.</description></item>
        /// <item><description>media (Array(Object), required): The list of media materials used to specify reference images and audio.<list type="bullet">
        /// <item><description>type (String, required): The type of the input media asset. Valid values: reference_image and reference_audio.</description></item>
        /// <item><description>url (String, required): The URL of the input media asset.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description>parameters (Object, required): The video generation parameter object.<list type="bullet">
        /// <item><description>duration (Integer, required): The video duration in seconds. The value must be a positive integer. Valid values: 5 to 15.</description></item>
        /// <item><description>ratio (String, required): The aspect ratio of the video. Valid values: 16:9, 9:16, 4:3, 3:4, and 1:1.</description></item>
        /// <item><description>resolution (String, required): The video resolution. Valid values: 720P and 1080P.</description></item>
        /// <item><description>specialEdition (Bool, optional): The cost-effective edition parameter. This parameter can be set to true only when the resolution is 1080P.</description></item>
        /// <item><description>skipPromptEnhancer (Bool, optional): Specifies whether to skip prompt enhancement. Default value: false.</description></item>
        /// <item><description>skipVoiceResync (Bool, optional): Specifies whether to skip audio repair. Default value: false.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;model\&quot;:\&quot;happyhorse-1.0-r2v\&quot;,\&quot;input\&quot;:{\&quot;prompt\&quot;:\&quot;[Image 1]中身着红色旗袍的女性，镜头先以侧面中景勾勒旗袍修身剪裁与S型曲线，随即切换至低角度仰拍，捕捉她轻抬玉手展开[Image 2]中的折扇的同时，[Image 3]中的流苏耳坠随头部转动轻盈摆动的细节，最后推近至面部特写，定格在她指尖轻点扇骨、眼波流转间的含蓄风情，多视角全方位展现东方韵味。\&quot;,\&quot;media\&quot;:[{\&quot;type\&quot;:\&quot;reference_image\&quot;,\&quot;url\&quot;:\&quot;<a href="https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/mvzfud/hh-v2v-girl.jpg%5C%5C%22%7D,%7B%5C%5C%22type%5C%5C%22:%5C%5C%22reference_image%5C%5C%22,%5C%5C%22url%5C%5C%22:%5C%5C%22https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/fvuihk/hh-v2v2-folding-fan.jpg%5C%5C%22%7D,%7B%5C%5C%22type%5C%5C%22:%5C%5C%22reference_image%5C%5C%22,%5C%5C%22url%5C%5C%22:%5C%5C%22https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/imerii/hh-v2v-earrings.jpg%5C%5C%22%7D%5D%7D,%5C%5C%22parameters%5C%5C%22:%7B%5C%5C%22resolution%5C%5C%22:%5C%5C%22720P%5C%5C%22,%5C%5C%22ratio%5C%5C%22:%5C%5C%2216:9%5C%5C%22,%5C%5C%22duration%5C%5C%22:5,%5C%5C%22specialEdition%5C%5C%22:false,%5C%5C%22skipPromptEnhancer%5C%5C%22:false,%5C%5C%22skipVoiceResync%5C%5C%22:false%7D%7D">https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/mvzfud/hh-v2v-girl.jpg\\&quot;},{\\&quot;type\\&quot;:\\&quot;reference_image\\&quot;,\\&quot;url\\&quot;:\\&quot;https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/fvuihk/hh-v2v2-folding-fan.jpg\\&quot;},{\\&quot;type\\&quot;:\\&quot;reference_image\\&quot;,\\&quot;url\\&quot;:\\&quot;https://help-static-aliyun-doc.aliyuncs.com/file-manage-files/zh-CN/20260424/imerii/hh-v2v-earrings.jpg\\&quot;}]},\\&quot;parameters\\&quot;:{\\&quot;resolution\\&quot;:\\&quot;720P\\&quot;,\\&quot;ratio\\&quot;:\\&quot;16:9\\&quot;,\\&quot;duration\\&quot;:5,\\&quot;specialEdition\\&quot;:false,\\&quot;skipPromptEnhancer\\&quot;:false,\\&quot;skipVoiceResync\\&quot;:false}}</a></para>
        /// </summary>
        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        /// <summary>
        /// <para>The custom user parameter, a JSON string. This parameter is returned as-is in the callback result. Example: newsKey.</para>
        /// <para>The system reserved field NotifyAddress specifies the callback URL. After the task is completed, a callback is sent. Example: {&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a>
        /// 系统保留字段 NotifyAddress，回调地址 URL，任务完成后回调 {&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
