// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshDcdnObjectCachesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to refresh resources in a directory if the resources are different from the resources in the same directory in the origin server. Default value: false.
        /// 
        /// *   **true**: refresh all resources in the directory.
        /// *   **false**: refresh the changed resources in the directory.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The path of the objects that you want to refresh. Separate multiple URLs with line feed characters (\n) or a pair of carriage return and line feed characters (\r\n).
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// The refresh type. Valid values:
        /// 
        /// *   **File** (default): refreshres resources based on URLs.
        /// *   **Directory**: refreshes resources based on directories.
        /// *   **Regex**: refreshes content based on regular expressions.
        /// *   **IgnoreParams**: removes the question mark (`?`) and parameters after `?` in a request URL and refreshes content. After you call this operation with the request URL submitted, the system compares the submitted URL with the URL of the cached resource without specific parameters. If the URLs match, the DCDN POPs refresh the cached resource.
        /// 
        /// >*   For more information about features of URL refresh and directory refresh, see [Refresh and prefetch resources](~~64936~~).
        /// >*   If you set ObjectType to Directory, the resources in the directory that you want to refresh are marked as expired. You cannot delete the directory. If clients request resources after the resources on POPs are marked as expired, DCDN checks whether the resources on your origin server are updated with a later version. If a later version exists, DCDN retrieves the resources of the later version and returns the resources to the clients. Otherwise, DCDN retrieves the 304 status code from the origin server.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
