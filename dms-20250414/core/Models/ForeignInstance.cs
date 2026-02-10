// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ForeignInstance : TeaModel {
        /// <summary>
        /// <para>The name of the data link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbl_mysql_2337</para>
        /// </summary>
        [NameInMap("DataLinkName")]
        [Validation(Required=false)]
        public string DataLinkName { get; set; }

        /// <summary>
        /// <para>The endpoint that is used to connect to the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The source of the database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC_OWN:</b> a self-managed database instance that is deployed on the Internet.</description></item>
        /// <item><description><b>RDS</b>: an ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ECS_OWN</b>: a self-managed database that is hosted on an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>VPC_IDC</b>: a self-managed database instance that is deployed in the data center over a virtual private cloud (VPC).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The port number that is used to connect to the database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7890</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The information of the properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The system identifier (SID) of the database.</para>
        /// <remarks>
        /// <para> The SID uniquely identifies an Oracle database. After a database is created, a SID is generated for the database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HXE</para>
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

    }

}
