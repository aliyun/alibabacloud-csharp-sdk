// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsMysqlDataSourceRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DgDatabaseId")]
        [Validation(Required=false)]
        public string DgDatabaseId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=CreateOmsMysqlDataSource
        /// &Name=oms-mysql
        /// &Type=INTERNET
        /// &VpcId=vpc-12345abcde*******
        /// &InstanceId=pc-12ab34cd56******
        /// &DgDatabaseId=dg-yhss6sdlaff****
        /// &Ip=10.0.****
        /// &Port=3306
        /// &Schema=test
        /// &Username=omsTestUser
        /// &Password=YWJjZDEyM0Ah
        /// &Description=MySQL data source for OMS testing
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
