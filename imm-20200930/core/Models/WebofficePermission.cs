// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficePermission : TeaModel {
        /// <summary>
        /// 拷贝
        /// </summary>
        [NameInMap("Copy")]
        [Validation(Required=false)]
        public bool? Copy { get; set; }

        /// <summary>
        /// 导出
        /// </summary>
        [NameInMap("Export")]
        [Validation(Required=false)]
        public bool? Export { get; set; }

        /// <summary>
        /// 查看历史版本
        /// </summary>
        [NameInMap("History")]
        [Validation(Required=false)]
        public bool? History { get; set; }

        /// <summary>
        /// 打印
        /// </summary>
        [NameInMap("Print")]
        [Validation(Required=false)]
        public bool? Print { get; set; }

        /// <summary>
        /// 只读模式
        /// </summary>
        [NameInMap("Readonly")]
        [Validation(Required=false)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// 重命名
        /// </summary>
        [NameInMap("Rename")]
        [Validation(Required=false)]
        public bool? Rename { get; set; }

    }

}
