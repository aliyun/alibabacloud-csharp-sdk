// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateAccountRequest : TeaModel {
        /// <summary>
        /// The description of the account.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("AccountDescription")]
        [Validation(Required=false)]
        public string AccountDescription { get; set; }

        /// <summary>
        /// The name of the database account.
        /// 
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name can contain lowercase letters, digits, and underscores (_).
        /// *   The name must be 2 to 16 characters in length.
        /// *   Reserved account names such as root, admin, and opsadmin cannot be used.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The password of the database account.
        /// 
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
        /// The type of the database account. Valid values:
        /// 
        /// *   **Normal**: standard account.
        /// *   **Super**: privileged account.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
