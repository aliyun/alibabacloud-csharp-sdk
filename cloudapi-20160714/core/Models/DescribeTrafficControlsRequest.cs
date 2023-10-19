// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsRequest : TeaModel {
        /// <summary>
        /// The specified API ID. This parameter must be specified together with GroupId and StageName.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// The specified group ID. This parameter must be specified together with ApiId and StageName.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The environment name. This parameter must be specified together with GroupId and ApiId. Valid values:********
        /// 
        /// *   **RELEASE**
        /// *   **TEST**
        /// </summary>
        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

        /// <summary>
        /// The ID of the throttling policy.
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// The name of the throttling policy.
        /// </summary>
        [NameInMap("TrafficControlName")]
        [Validation(Required=false)]
        public string TrafficControlName { get; set; }

    }

}
