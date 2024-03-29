// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppCallbackUrlRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 白板应用回调地址URL
        /// </summary>
        [NameInMap("AppCallbackUrl")]
        [Validation(Required=false)]
        public string AppCallbackUrl { get; set; }

        /// <summary>
        /// 白板应用回调鉴权码，由8~20位大小写字母、数字或下划线组成
        /// </summary>
        [NameInMap("AppCallbackAuthKey")]
        [Validation(Required=false)]
        public string AppCallbackAuthKey { get; set; }

    }

}
