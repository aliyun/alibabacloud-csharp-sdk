// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateRdsExternalStoreRequest : TeaModel {
        /// <summary>
        /// <para>The name of the external store.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_store</para>
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// <para>The parameter struct.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public UpdateRdsExternalStoreRequestParameter Parameter { get; set; }
        public class UpdateRdsExternalStoreRequestParameter : TeaModel {
            /// <summary>
            /// <para>The name of the database in the ApsaraDB RDS for MySQL instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>meta</para>
            /// </summary>
            [NameInMap("db")]
            [Validation(Required=false)]
            public string Db { get; set; }

            /// <summary>
            /// <para>The internal or public endpoint of the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1b6c719dfa08exf****</para>
            /// </summary>
            [NameInMap("instance-id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The password that is used to log on to the ApsaraDB RDS for MySQL instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sfdsfldsfksfls****</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The internal or public port of the ApsaraDB RDS for MySQL instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The region where the ApsaraDB RDS for MySQL instance resides. Valid values: cn-qingdao, cn-beijing, and cn-hangzhou.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The name of the database table in the ApsaraDB RDS for MySQL instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>join_meta</para>
            /// </summary>
            [NameInMap("table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <para>The username that is used to log on to the ApsaraDB RDS for MySQL instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the ApsaraDB RDS for MySQL instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1aevy8sofi8mh1q****</para>
            /// </summary>
            [NameInMap("vpc-id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The storage type. Set the value to rds-vpc, which indicates an ApsaraDB RDS for MySQL database in a virtual private cloud (VPC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds-vpc</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
