// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallRequest : TeaModel {
        /// <summary>
        /// APP ID。
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 频道ID。
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// 创建频道时间，使用UNIX时间戳表示，单位：秒。
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// 频道释放时间，使用UNIX时间戳表示，单位：秒。参数为空表示获取当前时间。
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// 查询的扩展。取值：USER_DURATION_STAT：用户时长统计数据类型。
        /// </summary>
        [NameInMap("ExtDataType")]
        [Validation(Required=false)]
        public string ExtDataType { get; set; }

        /// <summary>
        /// 是否查询通信体验信息，不传默认是true
        /// </summary>
        [NameInMap("QueryExpInfo")]
        [Validation(Required=false)]
        public bool? QueryExpInfo { get; set; }

    }

}
