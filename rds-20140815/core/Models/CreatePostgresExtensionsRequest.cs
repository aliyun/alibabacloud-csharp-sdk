// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreatePostgresExtensionsRequest : TeaModel {
        /// <summary>
        /// The account of the user who owns the extension. Only privileged accounts are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database name. You can call the DescribeDatabases operation to query the database name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBNames")]
        [Validation(Required=false)]
        public string DBNames { get; set; }

        /// <summary>
        /// The extension that you want to install. If you want to install multiple extensions, separate them with commas (,). If you do not specify the **SourceDatabase** parameter, you must specify this parameter.
        /// </summary>
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The risk description that you need to confirm. If your instance runs an outdated minor engine version, installing specific extensions on the instance poses security risks. Proceed with the installation only after you acknowledge these risks. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  For more information about the risks, see [Limits on extension creation for ApsaraDB RDS for PostgreSQL instances](https://help.aliyun.com/document_detail/2587815.html).
        /// </summary>
        [NameInMap("RiskConfirmed")]
        [Validation(Required=false)]
        public bool? RiskConfirmed { get; set; }

        /// <summary>
        /// The source database from which you want to synchronize the extension to the destination database. If you do not specify the **Extensions** parameter, you must specify this parameter.
        /// </summary>
        [NameInMap("SourceDatabase")]
        [Validation(Required=false)]
        public string SourceDatabase { get; set; }

    }

}
