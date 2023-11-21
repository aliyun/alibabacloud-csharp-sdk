// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteMultiAccountSQLQueryRequest : TeaModel {
        /// <summary>
        /// The SQL statement to be executed.
        /// 
        /// The number of characters in the SQL statement must be less than 2,000.
        /// 
        /// For more information about the SQL syntax, see [Basic SQL syntax](~~2539395~~).
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// The search scope. The value of this parameter can be one of the following items:
        /// 
        /// *   ID of a resource directory: Resources within the management account and all members of the resource directory are searched.
        /// *   ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched.
        /// *   ID of a folder: Resources within all members in the folder are searched.
        /// *   ID of a member: Resources within the member are searched.
        /// *   ID of a member/ID of a Resource group: Resources within the member in the resource group are searched.
        /// 
        /// For more information about how to obtain the ID of a resource directory, the Root folder, a folder, a member, or a resource group, see [GetResourceDirectory](~~159995~~), [ListFoldersForParent](~~159997~~), [ListFoldersForParent](~~159997~~), [ListAccounts](~~160016~~), or [ListResourceGroups](~~158855~~).
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
