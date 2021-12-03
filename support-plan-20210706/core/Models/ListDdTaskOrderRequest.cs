// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class ListDdTaskOrderRequest : TeaModel {
        /// <summary>
        /// callerParentId
        /// </summary>
        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        /// <summary>
        /// callerType
        /// </summary>
        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        /// <summary>
        /// callerUid
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        /// <summary>
        /// openGroupId
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// orderId
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// taskStatus
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
