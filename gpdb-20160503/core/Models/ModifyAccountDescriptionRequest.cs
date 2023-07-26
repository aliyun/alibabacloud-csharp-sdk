// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyAccountDescriptionRequest : TeaModel {
        /// <summary>
        /// The description of the account. The description must meet the following requirements:
        /// 
        /// *   The description must start with a letter.
        /// *   The description can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// 
        /// > You can call the [DescribeAccounts](~~~~) operation to query the information about database accounts in a cluster, including the database account name.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
