// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrimPolicy : TeaModel {
        /// <summary>
        /// 禁止删除所有空单元格
        /// </summary>
        [NameInMap("DisableDeleteEmptyCell")]
        [Validation(Required=false)]
        public bool? DisableDeleteEmptyCell { get; set; }

        /// <summary>
        /// 禁止删除所有重复样式
        /// </summary>
        [NameInMap("DisableDeleteRepeatedStyle")]
        [Validation(Required=false)]
        public bool? DisableDeleteRepeatedStyle { get; set; }

        /// <summary>
        /// 禁止删除未使用的单元格图片
        /// </summary>
        [NameInMap("DisableDeleteUnusedPicture")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedPicture { get; set; }

        /// <summary>
        /// 禁止删除没有使用的Shape
        /// </summary>
        [NameInMap("DisableDeleteUnusedShape")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedShape { get; set; }

    }

}
