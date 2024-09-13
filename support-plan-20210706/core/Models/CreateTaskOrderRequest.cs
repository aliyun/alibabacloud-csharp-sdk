// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("IsUrgent")]
        [Validation(Required=false)]
        public bool? IsUrgent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Overview")]
        [Validation(Required=false)]
        public string Overview { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("UrgentDescription")]
        [Validation(Required=false)]
        public string UrgentDescription { get; set; }

    }

}
