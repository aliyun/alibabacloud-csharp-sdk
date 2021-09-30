// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DeleteClassRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 课堂唯一标识。
        /// </summary>
        [NameInMap("ClassId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        /// <summary>
        /// 操作人用户ID，仅支持中英文数字，下划线，中划线，1~36个字符。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
