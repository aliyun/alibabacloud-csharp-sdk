// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderRequest : TeaModel {
        /// <summary>
        /// 建单人姓名：快手客户
        /// </summary>
        [NameInMap("CustomerRealName")]
        [Validation(Required=false)]
        public string CustomerRealName { get; set; }

        /// <summary>
        /// 建单人：固定值
        /// </summary>
        [NameInMap("CustomerUserId")]
        [Validation(Required=false)]
        public string CustomerUserId { get; set; }

        /// <summary>
        /// 重要性描述
        /// </summary>
        [NameInMap("ImportantDescription")]
        [Validation(Required=false)]
        public string ImportantDescription { get; set; }

        /// <summary>
        /// 是否紧急
        /// </summary>
        [NameInMap("IsImportant")]
        [Validation(Required=false)]
        public string IsImportant { get; set; }

        /// <summary>
        /// 主群关联Id
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// productType
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// 问题分类名称
        /// </summary>
        [NameInMap("ProductTypeName")]
        [Validation(Required=false)]
        public string ProductTypeName { get; set; }

        /// <summary>
        /// 任务单标题
        /// </summary>
        [NameInMap("TaskTitle")]
        [Validation(Required=false)]
        public string TaskTitle { get; set; }

    }

}
