// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class PredImageRequest : TeaModel {
        /// <summary>
        /// 是否垂直矫正
        /// </summary>
        [NameInMap("CorrectVertical")]
        [Validation(Required=false)]
        public bool? CorrectVertical { get; set; }

        /// <summary>
        /// 门数量(DetectDoor为false时，可为0)
        /// </summary>
        [NameInMap("CountDetectDoor")]
        [Validation(Required=false)]
        public long? CountDetectDoor { get; set; }

        /// <summary>
        /// 是否门预测
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

    }

}
