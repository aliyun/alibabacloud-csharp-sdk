// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDBLinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the source cluster that the database link connects.
        /// 
        /// >  You can call the [DescribeDBClusters](~~173433~~) operation to query PolarDB clusters.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database link.
        /// 
        /// *   The name must contain lowercase letters and can also contain digits and underscores (\_).
        /// *   The name must start with a letter and end with a letter or digit.
        /// *   The name must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("DBLinkName")]
        [Validation(Required=false)]
        public string DBLinkName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// >  You can call the [DescribeRegions](~~98041~~) operation to query information about regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// The name of the source database.
        /// 
        /// >  You can call the [DescribeDatabases](~~173558~~) operation to query information about databases in a PolarDB cluster.
        /// </summary>
        [NameInMap("SourceDBName")]
        [Validation(Required=false)]
        public string SourceDBName { get; set; }

        /// <summary>
        /// The account of the destination database.
        /// 
        /// >  You can call the [DescribeAccounts](~~173549~~) operation to query the account of a PolarDB cluster.
        /// </summary>
        [NameInMap("TargetDBAccount")]
        [Validation(Required=false)]
        public string TargetDBAccount { get; set; }

        /// <summary>
        /// The ID of the destination cluster that the database link connects.
        /// 
        /// > *   If the destination cluster is a user-created Oracle database on an ECS instance, set the value to `null`.
        /// > *   You can call the [DescribeDBClusters](~~173433~~) operation to query PolarDB clusters.
        /// </summary>
        [NameInMap("TargetDBInstanceName")]
        [Validation(Required=false)]
        public string TargetDBInstanceName { get; set; }

        /// <summary>
        /// The name of the destination database.
        /// 
        /// >  You can call the [DescribeDatabases](~~173558~~) operation to query information about databases in a PolarDB cluster.
        /// </summary>
        [NameInMap("TargetDBName")]
        [Validation(Required=false)]
        public string TargetDBName { get; set; }

        /// <summary>
        /// The account password of the destination database.
        /// </summary>
        [NameInMap("TargetDBPasswd")]
        [Validation(Required=false)]
        public string TargetDBPasswd { get; set; }

        /// <summary>
        /// The IP address of the user-created Oracle database on an ECS instance.
        /// </summary>
        [NameInMap("TargetIp")]
        [Validation(Required=false)]
        public string TargetIp { get; set; }

        /// <summary>
        /// The port number of the user-created Oracle database on an ECS instance.
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// 
        /// >  You can call the [DescribeVpcs](~~35739~~) operation to query information about VPCs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
