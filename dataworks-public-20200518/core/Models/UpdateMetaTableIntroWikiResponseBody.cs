// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateMetaTableIntroWikiResponseBody : TeaModel {
        /// <summary>
        /// The request ID. You can troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the instructions on how to use the table are updated.
        /// </summary>
        [NameInMap("UpdateResult")]
        [Validation(Required=false)]
        public bool? UpdateResult { get; set; }

    }

}
