// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyAccountDescriptionRequest : TeaModel {
        /// <summary>
        /// The new description of the database account.
        /// 
        /// *   The description must start with a letter.
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description can contain letters, underscores (\_), hyphens (-), and digits.
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

    }

}
