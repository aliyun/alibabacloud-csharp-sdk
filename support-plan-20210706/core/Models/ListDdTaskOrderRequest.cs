// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class ListDdTaskOrderRequest : TeaModel {
        /// <summary>
        /// createRealName
        /// </summary>
        [NameInMap("CreateRealName")]
        [Validation(Required=false)]
        public string CreateRealName { get; set; }

        /// <summary>
        /// endTime
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("IsUrgent")]
        [Validation(Required=false)]
        public bool? IsUrgent { get; set; }

        /// <summary>
        /// openGroupId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// pageNo
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// startTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// taskStatus
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
