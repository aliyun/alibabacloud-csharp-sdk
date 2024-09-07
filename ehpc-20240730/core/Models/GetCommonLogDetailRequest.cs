// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetCommonLogDetailRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        [NameInMap("HiddenProcess")]
        [Validation(Required=false)]
        public bool? HiddenProcess { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogRequestId")]
        [Validation(Required=false)]
        public string LogRequestId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
