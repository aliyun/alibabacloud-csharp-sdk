// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemResponseBody : TeaModel {
        /// <summary>
        /// The information about the file system that was created.
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<string> AllocationId { get; set; }

        /// <summary>
        /// The status code for successful operations. Valid values:
        /// 
        /// *   PartSuccess: The operation is partially successful.
        /// *   AllSuccess: The operation is successful.
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the file system that failed to be created.
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<string> UnAllocationId { get; set; }

    }

}
