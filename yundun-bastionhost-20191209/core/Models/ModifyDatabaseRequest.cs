// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The address type of the database after the modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Public</b>: public network address</description></item>
        /// <item><description><b>Private</b>: private network address</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ActiveAddressType")]
        [Validation(Required=false)]
        public string ActiveAddressType { get; set; }

        /// <summary>
        /// <para>The description of the database after the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tttttttt</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the database to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// <para>The name of the database instance after the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgsql</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The port of the database after the modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5433</para>
        /// </summary>
        [NameInMap("DatabasePort")]
        [Validation(Required=false)]
        public string DatabasePort { get; set; }

        /// <summary>
        /// <para>The private network address of the database after the modification. IPv4 addresses and domain name formats are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DatabasePrivateAddress")]
        [Validation(Required=false)]
        public string DatabasePrivateAddress { get; set; }

        /// <summary>
        /// <para>The public address of the database after the modification. Both IPv4 addresses and domain names are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("DatabasePublicAddress")]
        [Validation(Required=false)]
        public string DatabasePublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the Bastionhost instance to which the database to be modified belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-72137xe5n01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the network domain to which the database belongs after the modification.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2758827.html">ListNetworkDomains </a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkDomainId")]
        [Validation(Required=false)]
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance to which the database to be modified belongs.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the database to be modified.  </para>
        /// <remarks>
        /// <para>This parameter is required if <b>Source</b> is set to <b>Rds</b> or <b>PolarDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-wz99nexqd62z3bvuvpz5</para>
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

    }

}
