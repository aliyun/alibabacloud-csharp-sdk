// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class AddHDMInstanceRequest : TeaModel {
        /// <summary>
        /// The database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PostgreSQL**
        /// *   **SQLServer**
        /// *   **PolarDBMySQL**
        /// *   **PolarDBPostgreSQL**
        /// *   **Redis**
        /// *   **MongoDB**
        /// *   **PolarDBOracle**
        /// *   **PolarDBX**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("FlushAccount")]
        [Validation(Required=false)]
        public string FlushAccount { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// The type of the instance on which the database is deployed. Valid values:
        /// 
        /// *   **RDS**: an Alibaba Cloud database instance.
        /// *   **ECS**: an Elastic Compute Service (ECS) instance on which a self-managed database is deployed.
        /// *   **IDC**: a self-managed database instance that is not deployed on Alibaba Cloud.
        /// 
        /// >  IDC refers to your data center.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceArea")]
        [Validation(Required=false)]
        public string InstanceArea { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The endpoint that is used to access the instance over internal networks.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The network type of the instance.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The password for the username.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The port that is used to access the instance over internal networks.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The username that is used to log on to the database.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}
