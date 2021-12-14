// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateClassRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识，由6位小写字母、数字组成。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 课堂唯一标识。
        /// </summary>
        [NameInMap("ClassId")]
        [Validation(Required=false)]
        public string ClassId { get; set; }

        /// <summary>
        /// 创建人用户昵称，1~32个字符。
        /// </summary>
        [NameInMap("CreateNickname")]
        [Validation(Required=false)]
        public string CreateNickname { get; set; }

        /// <summary>
        /// 创建人用户ID，仅支持中英文数字，下划线，中划线，1~36个字符。
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 课堂标题，1~32个字符。
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
