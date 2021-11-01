/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectObjectElement : TeaModel {
        /// <summary>
        /// 目标高度(像素)
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// 目标置信度，范围为[0.0, 1.0]
        /// </summary>
        [NameInMap("Score")]
        [Validation(Required=false)]
        public float? Score { get; set; }

        /// <summary>
        /// 目标类型：PERSON, VEHICLE, PET
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 目标宽度(像素)
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

        /// <summary>
        /// 左上角x坐标(像素)
        /// </summary>
        [NameInMap("X")]
        [Validation(Required=false)]
        public long? X { get; set; }

        /// <summary>
        /// 左上角y坐标(像素)
        /// </summary>
        [NameInMap("Y")]
        [Validation(Required=false)]
        public long? Y { get; set; }

    }

}
