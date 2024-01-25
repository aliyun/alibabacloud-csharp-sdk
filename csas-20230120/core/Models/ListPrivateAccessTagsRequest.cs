// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPrivateAccessTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the internal access application. You can obtain the application ID by calling the following operations:
        /// 
        /// *   [ListPrivateAccessApplications](~~ListPrivateAccessApplications~~): queries all internal access applications.
        /// *   [CreatePrivateAccessApplication](~~CreatePrivateAccessApplication~~): creates an internal access application.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// The page number. Valid values: 1 to 10000.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the internal access tag. The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the internal access policy. You can obtain the policy ID by calling the following operations:
        /// 
        /// *   [ListPrivateAccessPolices](~~ListPrivateAccessPolices~~): queries all internal access policies.
        /// *   [CreatePrivateAccessPolicy](~~CreatePrivateAccessPolicy~~): creates an internal access policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Specifies whether to enable the simple query mode. A value of true specifies that policy IDs are not queried.
        /// </summary>
        [NameInMap("SimpleMode")]
        [Validation(Required=false)]
        public bool? SimpleMode { get; set; }

        /// <summary>
        /// The IDs of internal access tags. You can specify up to 100 tag IDs.
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
