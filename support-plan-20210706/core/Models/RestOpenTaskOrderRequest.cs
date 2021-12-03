// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class RestOpenTaskOrderRequest : TeaModel {
        /// <summary>
        /// 主群关联Id
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// 任务单ID
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 重开说明
        /// </summary>
        [NameInMap("ResetContent")]
        [Validation(Required=false)]
        public string ResetContent { get; set; }

        /// <summary>
        /// 重开类型
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

        /// <summary>
        /// 操作人姓名
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
