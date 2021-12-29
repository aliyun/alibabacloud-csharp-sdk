// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveRoomShrinkRequest : TeaModel {
        /// <summary>
        /// 主播id，仅支持英文和数字，最大长度36位。
        /// </summary>
        [NameInMap("AnchorId")]
        [Validation(Required=false)]
        public string AnchorId { get; set; }

        /// <summary>
        /// 主播昵称。
        /// </summary>
        [NameInMap("AnchorNick")]
        [Validation(Required=false)]
        public string AnchorNick { get; set; }

        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 封面，支持图片地址链接格式
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 拓展字段，按需传递，需要额外记录的房间属性。
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string ExtensionShrink { get; set; }

        /// <summary>
        /// 公告，支持中英文，最大长度256位。
        /// </summary>
        [NameInMap("Notice")]
        [Validation(Required=false)]
        public string Notice { get; set; }

        /// <summary>
        /// 标题，支持中英文，最大长度32位。
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 操作人ID。
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
