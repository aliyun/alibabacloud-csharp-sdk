// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateShareScreenLayoutRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 课堂唯一标识，由调用CreateClass返回。
        /// </summary>
        [NameInMap("ClassId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        /// <summary>
        /// 是否开启叠加老师画面
        /// </summary>
        [NameInMap("EnableOverlay")]
        [Validation(Required=false)]
        public bool? EnableOverlay { get; set; }

        /// <summary>
        /// 叠加画面高度，归一化为1
        /// </summary>
        [NameInMap("OverlayHeight")]
        [Validation(Required=false)]
        public float? OverlayHeight { get; set; }

        /// <summary>
        /// 叠加画面宽度，归一化为1
        /// </summary>
        [NameInMap("OverlayWidth")]
        [Validation(Required=false)]
        public float? OverlayWidth { get; set; }

        /// <summary>
        /// 叠加画面X坐标，归一化为1
        /// </summary>
        [NameInMap("OverlayX")]
        [Validation(Required=false)]
        public float? OverlayX { get; set; }

        /// <summary>
        /// 叠加画面Y坐标，归一化为1
        /// </summary>
        [NameInMap("OverlayY")]
        [Validation(Required=false)]
        public float? OverlayY { get; set; }

    }

}
