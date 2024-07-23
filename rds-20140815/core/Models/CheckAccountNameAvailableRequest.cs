// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckAccountNameAvailableRequest : TeaModel {
        /// <summary>
        /// <para>The username of the account.</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be unique.</para>
        /// </description></item>
        /// <item><description><para>The value must start with a lowercase letter, and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>The value can contain lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The length of the value must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>If the instance runs MySQL 5.7 or MySQL 8.0, the value must be 2 to 32 characters in length.</description></item>
        /// <item><description>If the instance runs MySQL 5.6, the value must be 2 to 16 characters in length.</description></item>
        /// <item><description>If the instance runs SQL Server, the value must be 2 to 64 characters in length.</description></item>
        /// <item><description>If the instance runs PostgreSQL with cloud disks, the value must be 2 to 63 characters in length.</description></item>
        /// <item><description>If the instance runs PostgreSQL with local disks, the value must be 2 to 16 characters in length.</description></item>
        /// <item><description>If the instance runs MariaDB, the value must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For more information about invalid characters, see <a href="https://help.aliyun.com/document_detail/26317.html">Forbidden keywords table</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DatabaseTest</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
