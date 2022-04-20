// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateSensitiveWordRequest : TeaModel {
        /// <summary>
        /// 用户的应用ID，在控制台创建应用时生成。包含小写字母、数字，长度为6个字符。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("WordList")]
        [Validation(Required=false)]
        public List<string> WordList { get; set; }

    }

}
