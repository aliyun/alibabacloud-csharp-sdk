// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobShrinkRequest : TeaModel {
        /// <summary>
        /// 任务输入组 (目前只支持一个)
        /// </summary>
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public string InputGroupShrink { get; set; }

        /// <summary>
        /// 任务名字
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 任务输出组
        /// </summary>
        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public string OutputGroupShrink { get; set; }

        /// <summary>
        /// 任务调度信息
        /// </summary>
        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// 用户数据
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
