// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SwitchApiRequest : TeaModel {
        /// <summary>
        /// The description of the switch operation.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the runtime environment. Valid values:
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// *   This API is intended for API providers.
        /// *   The historical version can be obtained through the DescribeHistoryApis API.****
        /// *   Only APIs that have been published more than once have historical versions to switch to.
        /// *   This operation can only be performed on running APIs. Use caution when performing this operation because the operation cannot be undone after it has been completed and takes effect within 5 seconds.
        /// *   The switch operation is in essence a publish operation, and the reason for this operation must be provided.
        /// </summary>
        [NameInMap("HistoryVersion")]
        [Validation(Required=false)]
        public string HistoryVersion { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The historical version you want to switch to.
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
