// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsMysqlDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the data source.   </para>
        /// <para>It must be 2 to 256 characters in length. The default value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL data source for OMS testing</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the database gateway instance.   </para>
        /// <remarks>
        /// <para><br>If Type is set to DG, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dg-yhss6sdlaff****</para>
        /// </summary>
        [NameInMap("DgDatabaseId")]
        [Validation(Required=false)]
        public string DgDatabaseId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance of the data source.   </para>
        /// <remarks>
        /// <para><br>If Type is set to RDS, PolarDB, or DG, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-12ab34cd56******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the data source.   </para>
        /// <remarks>
        /// <para><br>If Type is set to INTERNET or VPC, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.****</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The name of the data source.<br>It must be 2 to 128 characters in length and can contain letters, digits, underscores (_), periods (.), and hyphens (-).   </para>
        /// <remarks>
        /// <para><br>Invalid characters, such as slashes (/), are not allowed.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oms-mysql</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The password of the username that is used to access the database. It must be Base64 encoded.<br>For example, for the password abcd123@!, the Base64-encoded value is YWJjZDEyM0Ah.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YWJjZDEyM0Ah</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port number of the data source.   </para>
        /// <remarks>
        /// <para><br>If Type is set to INTERNET or VPC, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The name of the database.   </para>
        /// <remarks>
        /// <para><br>If you specify this parameter, subsequent migration or synchronization operations will take effect on this database only.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The type of the MySQL data source.<br>Valid values: INTERNET, VPC, RDS, PolarDB, and DG.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The username that is used to access the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>omsTestUser</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the data source belongs.   </para>
        /// <remarks>
        /// <para><br>If Type is set to VPC, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-12345abcde*******</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
