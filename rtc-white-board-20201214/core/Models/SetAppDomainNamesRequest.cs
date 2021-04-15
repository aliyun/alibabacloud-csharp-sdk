// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppDomainNamesRequest : TeaModel {
        /// <summary>
        /// 白板应用唯一标识符
        /// </summary>
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        /// <summary>
        /// 所有会使用到白板应用的客户网站域名，多个使用英文逗号(,)分隔，最多传10个
        /// </summary>
        [NameInMap("AppDomainNames")]
        [Validation(Required=false)]
        public string AppDomainNames { get; set; }

    }

}
