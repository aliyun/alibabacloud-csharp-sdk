// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListPoliciesForTargetRequest : TeaModel {
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
        /// The region ID. Set the value to cn-shanghai.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the object. This parameter specifies a filter condition for the query.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the object. This parameter specifies a filter condition for the query. Valid values:
        /// 
        /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
        /// *   ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// 
        /// >  The value of this parameter is not case-sensitive.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
