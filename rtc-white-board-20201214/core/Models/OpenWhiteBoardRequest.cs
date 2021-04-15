// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class OpenWhiteBoardRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 打开白板的用户ID（客户业务用户），由纯数字组成
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 白板文档唯一标识符
        /// </summary>
        [NameInMap("DocKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

    }

}
