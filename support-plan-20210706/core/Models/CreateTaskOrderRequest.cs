// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderRequest : TeaModel {
        [NameInMap("CustomerRealName")]
        [Validation(Required=false)]
        public string CustomerRealName { get; set; }

        [NameInMap("CustomerUserId")]
        [Validation(Required=false)]
        public string CustomerUserId { get; set; }

        [NameInMap("ImportantDescription")]
        [Validation(Required=false)]
        public string ImportantDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IsImportant")]
        [Validation(Required=false)]
        public string IsImportant { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// productType
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ProductTypeName")]
        [Validation(Required=false)]
        public string ProductTypeName { get; set; }

        /// <summary>
        /// taskTitle
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskTitle")]
        [Validation(Required=false)]
        public string TaskTitle { get; set; }

    }

}
