// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitCopyrightJobRequest : TeaModel {
        /// <summary>
        /// 任务结果回调url
        /// </summary>
        [NameInMap("CallBack")]
        [Validation(Required=false)]
        public string CallBack { get; set; }

        /// <summary>
        /// 水印信息描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 输入的视频，oss三元组
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// 水印强度，取值1，2，3
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// 水印信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 输出的视频，oss三元组
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// 水印起始时间(单位是秒)，不填写默认为0
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 水印结束时间(单位是秒)，不填默认为60000
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public long? TotalTime { get; set; }

        /// <summary>
        /// 外部url链接(Input和url二选一)
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// 用户自定义数据
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// 可见水印(必须是英文字符)
        /// </summary>
        [NameInMap("VisibleMessage")]
        [Validation(Required=false)]
        public string VisibleMessage { get; set; }

    }

}
