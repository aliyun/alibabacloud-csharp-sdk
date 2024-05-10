// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateRdsExternalStoreRequest : TeaModel {
        /// <summary>
        /// The name of the external store. The name must be unique in a project and must be different from Logstore names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// The parameter struct.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public CreateRdsExternalStoreRequestParameter Parameter { get; set; }
        public class CreateRdsExternalStoreRequestParameter : TeaModel {
            /// <summary>
            /// The name of the database in the ApsaraDB RDS for MySQL instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("db")]
            [Validation(Required=false)]
            public string Db { get; set; }

            /// <summary>
            /// The internal or public endpoint of the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The ID of the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("instance-id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The password that is used to log on to the ApsaraDB RDS for MySQL instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The internal or public port of the ApsaraDB RDS for MySQL instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The region where the ApsaraDB RDS for MySQL instance resides. Valid values: cn-qingdao, cn-beijing, and cn-hangzhou.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The name of the database table in the ApsaraDB RDS for MySQL instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// The username that is used to log on to the ApsaraDB RDS for MySQL instance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// The ID of the VPC to which the ApsaraDB RDS for MySQL instance belongs.
            /// </summary>
            [NameInMap("vpc-id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The storage type. Set the value to rds-vpc, which indicates an ApsaraDB RDS for MySQL database in a virtual private cloud (VPC).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
