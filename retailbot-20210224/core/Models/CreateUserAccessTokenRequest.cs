// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class CreateUserAccessTokenRequest : TeaModel {
        /// <summary>
        /// 用户的阿里云账号ID。下单购买时的主账号ID
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// 自定义token的失效时间。单位秒
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 额外信息，必须是JSON String格式
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 系统颁发的sourceId
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// 系统颁发的sourceKey。鉴权使用
        /// </summary>
        [NameInMap("SourceKey")]
        [Validation(Required=false)]
        public string SourceKey { get; set; }

        /// <summary>
        /// User dto
        /// </summary>
        [NameInMap("UserDto")]
        [Validation(Required=false)]
        public CreateUserAccessTokenRequestUserDto UserDto { get; set; }
        public class CreateUserAccessTokenRequestUserDto : TeaModel {
            [NameInMap("ForeignId")]
            [Validation(Required=false)]
            public string ForeignId { get; set; }
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }
        };

    }

}
