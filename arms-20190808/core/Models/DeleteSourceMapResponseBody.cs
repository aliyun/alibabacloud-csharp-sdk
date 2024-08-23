// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSourceMapResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the SourceMap files are deleted. Valid values:
        /// 
        /// *   success: The SourceMap files are deleted.
        /// *   false: The SourceMap files fail to be deleted.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
