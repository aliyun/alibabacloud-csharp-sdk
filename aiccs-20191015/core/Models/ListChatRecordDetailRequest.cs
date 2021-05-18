// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListChatRecordDetailRequest : TeaModel {
        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 在线挂断的时间范围
        /// </summary>
        [NameInMap("CloseTimeEnd")]
        [Validation(Required=false)]
        public long? CloseTimeEnd { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// 每页数据量
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 在线挂断的时间范围
        /// </summary>
        [NameInMap("CloseTimeStart")]
        [Validation(Required=false)]
        public long? CloseTimeStart { get; set; }

    }

}
