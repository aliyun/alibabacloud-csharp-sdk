// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveRecordRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 直播唯一标识，由调用CreateLiveRoom返回。
        /// </summary>
        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// 操作人用户ID。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
