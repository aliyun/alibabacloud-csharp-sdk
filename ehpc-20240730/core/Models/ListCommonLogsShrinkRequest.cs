// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListCommonLogsShrinkRequest : TeaModel {
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionNameShrink { get; set; }

        [NameInMap("ActionStatus")]
        [Validation(Required=false)]
        public string ActionStatus { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("IsReverse")]
        [Validation(Required=false)]
        public bool? IsReverse { get; set; }

        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("OperatorUid")]
        [Validation(Required=false)]
        public string OperatorUid { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
