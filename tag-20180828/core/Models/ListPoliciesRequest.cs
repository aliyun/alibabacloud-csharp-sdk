// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListPoliciesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 50. Maximum value: 1000.
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of a tag policy. This parameter specifies a filter condition for the query.
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

        /// <summary>
        /// The name of a tag policy. This parameter specifies a filter condition for the query.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public List<string> PolicyNames { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The mode of the Tag Policy feature. This parameter specifies a filter condition for the query. Valid values:
        /// 
        /// *   USER: single-account mode
        /// *   RD: multi-account mode
        /// 
        /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
        /// 
        /// >  The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
