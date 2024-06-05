// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListShareLinkRequest : TeaModel {
        /// <summary>
        /// The creator of the share.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// Specifies whether to return the shares that are canceled.
        /// </summary>
        [NameInMap("include_cancelled")]
        [Validation(Required=false)]
        public bool? IncludeCancelled { get; set; }

        /// <summary>
        /// The maximum number of results to return. Valid values: 0 to 100.
        /// 
        /// The number of returned results must be less than or equal to the specified number.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\\
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The field by which to sort the returned results. Default value: created_at. Valid values:
        /// 
        /// *   share_name: sorts the results by the name of the share.
        /// *   updated_at: sorts the results by the time when the share was modified.
        /// *   description: sorts the results by the description of the share.
        /// *   created_at: sorts the results by the time when the share was created.
        /// </summary>
        [NameInMap("order_by")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the returned results. By default, order_direction is set to DESC if order_by is set to created_at or updated_at, and is set to ASC if order_by is set to other values. Valid values:
        /// 
        /// *   ASC: sorts the results in ascending order.
        /// *   DESC: sorts the results in descending order.
        /// </summary>
        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

    }

}
