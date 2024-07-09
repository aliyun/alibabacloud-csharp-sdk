// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointsRequest : TeaModel {
        /// <summary>
        /// The keyword used to filter endpoints in %keyword% mode.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The state of the endpoint that you want to query. If you do not specify this parameter, all endpoints are returned. Valid values:
        /// 
        /// *   SUCCESS: The endpoint works as expected.
        /// *   INIT: The endpoint is being created.
        /// *   FAILED: The endpoint fails to be created.
        /// *   CHANGE_INIT: The endpoint is being modified.
        /// *   CHANGE_FAILED: The endpoint fails to be modified.
        /// *   EXCEPTION: The endpoint encounters an exception.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
