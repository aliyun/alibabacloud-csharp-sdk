/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，可以包含小写字母、数字，长度为6个字符。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 房间ID，最大长度36个字符，传空值，则随机生成一个房间ID。
        /// </summary>
        [NameInMap("RoomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// 创建直播用户。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 直播资源的唯一标识ID，缺省时系统自动生成36位随机uuid字符串。
        /// </summary>
        [NameInMap("LiveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// 直播标题，支持中英文，最大长度256位。
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 直播简介，支持中英文，最大长度2048位。
        /// </summary>
        [NameInMap("Introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 主播ID，支持中英文，最大长度128位，缺省时主播为当前创建直播用户。
        /// </summary>
        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        /// <summary>
        /// 直播推流码率，缺省时默认为3。取值：  -1：流畅lld。 1：标清lsd。 2：高清lhd。 3：超清lud。
        /// </summary>
        [NameInMap("CodeLevel")]
        [Validation(Required=false)]
        public int? CodeLevel { get; set; }

    }

}
