// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshErObjectCachesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to refresh resources in a directory if the resources requested are different from the resources on the origin server. Default value: false.
        /// 
        /// *   **true**: refreshes all resources in the directory.
        /// *   **false**: refreshes the changed resources in the directory.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The domain names that are merged for refreshing. POPs that provide services for the domain names are refreshed.
        /// 
        /// >  Separate multiple domain names with commas (,).
        /// </summary>
        [NameInMap("MergeDomainName")]
        [Validation(Required=false)]
        public string MergeDomainName { get; set; }

        /// <summary>
        /// The URL that you want to refresh.
        /// 
        /// > *   Separate URLs with line feeds (\\n or \\r\\n). Each object path can be up to 1,024 characters in length.
        /// >*   The URLs in a request must belong to the same domain name.
        /// >*   You can refresh up to 1,000 URLs in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        /// <summary>
        /// The refresh type. Valid values:
        /// 
        /// *   **File** (default): refreshes content based on URLs.
        /// *   **Directory**: refreshes content based on directories.
        /// *   **Regex**: refreshes content based on regular expressions.
        /// *   **IgnoreParams**: removes the question mark (`?`) and parameters after the question mark (`?`) in a request URL and refreshes content. After you call this operation with the request URL submitted, the system compares the submitted URL with the URL of the cached resource without specific parameters. If the URLs match, the points of presence (POPs) refresh the cached resource.
        /// 
        /// >  If you refresh the files in one or more directories, the resources in the directory that you want to refresh are marked as expired. You cannot delete the directory. If clients request resources on POPs that are marked as expired, Dynamic Content Delivery Network (DCDN) checks whether the resources on your origin server are updated. If resources are updated, DCDN retrieves the latest version of the resources and returns the resources to the clients. Otherwise, the origin server returns the 304 status code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The ID of the routine, which is in the format of "Name.Subdomain" and is the unique identifier of a custom routine.
        /// </summary>
        [NameInMap("RoutineId")]
        [Validation(Required=false)]
        public string RoutineId { get; set; }

    }

}
