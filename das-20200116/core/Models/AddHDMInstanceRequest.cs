// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class AddHDMInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PolarDBMySQL</b></description></item>
        /// <item><description><b>PolarDBPostgreSQL</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>PolarDBOracle</b></description></item>
        /// <item><description><b>PolarDBX</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("FlushAccount")]
        [Validation(Required=false)]
        public string FlushAccount { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yuecq--test****</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The type of the instance on which the database is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: an Alibaba Cloud database instance.</description></item>
        /// <item><description><b>ECS</b>: an Elastic Compute Service (ECS) instance on which a self-managed database is deployed.</description></item>
        /// <item><description><b>IDC</b>: a self-managed database instance that is not deployed on Alibaba Cloud.</description></item>
        /// </list>
        /// <remarks>
        /// <para> IDC refers to your data center.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("InstanceArea")]
        [Validation(Required=false)]
        public string InstanceArea { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The endpoint that is used to access the instance over internal networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The network type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password for the username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port that is used to access the instance over internal networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The username that is used to log on to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test****</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5e666n89m2bx8jar****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}
