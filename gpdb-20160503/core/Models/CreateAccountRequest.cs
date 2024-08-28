// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the initial account.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the initial account.
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (_).
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name cannot start with gp.
        /// *   The name must be 2 to 16 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the initial account.
        /// *   The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters.
        /// *   Special characters include `! @ # $ % ^ & * ( ) _ + - =`
        /// *   The password must be 8 to 32 characters in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// The type of the initial account. Default value: Super, which specifies a privileged account. To create a standard account, set the value to Normal.
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is no longer used.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
