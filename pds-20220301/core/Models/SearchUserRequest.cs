// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchUserRequest : TeaModel {
        /// <summary>
        /// The email address of the user.
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The maximum number of results to return. Valid values: 1 to 100. Default value: 100.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.\
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The nickname of the user. The nickname can be up to 128 characters in length.
        /// </summary>
        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// The nickname used for fuzzy searches. The nickname can be up to 128 characters in length.
        /// </summary>
        [NameInMap("nick_name_for_fuzzy")]
        [Validation(Required=false)]
        public string NickNameForFuzzy { get; set; }

        /// <summary>
        /// The mobile number of the user.
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The role of the user. Valid values:
        /// 
        /// *   superadmin
        /// *   admin
        /// *   user
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The state of the user. Valid values:
        /// 
        /// *   disabled: The user is prohibited from logon.
        /// *   enabled: The user is in a normal state.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The name of the user. The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
