// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppNameRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 白板应用名，由不超过32位的中文、英文、数字或下划线组成
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

    }

}
