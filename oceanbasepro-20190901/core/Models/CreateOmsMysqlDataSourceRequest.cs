// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsMysqlDataSourceRequest : TeaModel {
        /// <summary>
        /// The description of the data source.   
        /// It must be 2 to 256 characters in length. The default value is null.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the database gateway instance.   
        /// 
        /// > <br>If Type is set to DG, this parameter is required.
        /// </summary>
        [NameInMap("DgDatabaseId")]
        [Validation(Required=false)]
        public string DgDatabaseId { get; set; }

        /// <summary>
        /// The ID of the ECS instance of the data source.   
        /// 
        /// > <br>If Type is set to RDS, POLARDB, or DG, this parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the data source.   
        /// 
        /// > <br>If Type is set to INTERNET or VPC, this parameter is required.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The name of the data source.   
        /// It must be 2 to 128 characters in length and can contain letters, digits, underscores (_), periods (.), and hyphens (-).   
        /// 
        /// > <br>Invalid characters, such as slashes (/), are not allowed.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The password of the username that is used to access the database. It must be Base64 encoded.   
        /// For example, for the password abcd123@!, the Base64-encoded value is YWJjZDEyM0Ah.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The port number of the data source.   
        /// 
        /// > <br>If Type is set to INTERNET or VPC, this parameter is required.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The name of the database.   
        /// 
        /// > <br>If you specify this parameter, subsequent migration or synchronization operations will take effect on this database only.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// The type of the MySQL data source.   
        /// Valid values: INTERNET, VPC, RDS, POLARDB, and DG.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The username that is used to access the database.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The ID of the VPC to which the data source belongs.   
        /// 
        /// > <br>If Type is set to VPC, this parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
