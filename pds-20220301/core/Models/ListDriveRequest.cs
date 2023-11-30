// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDriveRequest : TeaModel {
        /// <summary>
        /// The maximum number of results to return. Valid values: 1 to 100. Default value: 100.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker. By default, this parameter is empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The owner of the drive. If this parameter is not specified, all drives are returned.
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The type of the owner. Valid values:
        /// 
        /// user and group.
        /// 
        /// By default, drives of all owner types are returned.
        /// </summary>
        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

    }

}
