// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class RectVerticalRequest : TeaModel {
        /// <summary>
        /// 需要预测的门的数量
        /// </summary>
        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public int? CountDetectDoor { get; set; }

        /// <summary>
        /// 是否开启门预测
        /// </summary>
        [NameInMap("DetectDoor")]
        [Validation(Required=false)]
        public bool? DetectDoor { get; set; }

        /// <summary>
        /// 子场景ID
        /// </summary>
        [NameInMap("SubSceneId")]
        [Validation(Required=false)]
        public string SubSceneId { get; set; }

        /// <summary>
        /// 矫正数据
        /// </summary>
        [NameInMap("VerticalRect")]
        [Validation(Required=false)]
        public string VerticalRect { get; set; }

    }

}
