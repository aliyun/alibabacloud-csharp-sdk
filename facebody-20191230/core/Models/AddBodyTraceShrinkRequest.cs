// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddBodyTraceShrinkRequest : TeaModel {
        /// <summary>
        /// 数据库ID
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// 自定义信息。支持字母、数字、标点符号和汉字。不超过4096个字符。
        /// </summary>
        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// Trace图片信息列表
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public string ImagesShrink { get; set; }

        /// <summary>
        /// 实体ID，可以包含数字、字母和下划线，相同db下不可以重复，长度1-64。
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public long? PersonId { get; set; }

    }

}
