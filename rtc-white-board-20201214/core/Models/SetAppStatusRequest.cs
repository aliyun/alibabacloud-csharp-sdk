// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppStatusRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 白板应用状态（取值：1:启用，2:停用）
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public long? AppStatus { get; set; }

    }

}
