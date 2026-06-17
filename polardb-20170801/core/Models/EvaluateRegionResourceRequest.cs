// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceRequest : TeaModel {
        /// <summary>
        /// <para>The link type of the cluster. The backend randomly selects a default value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lvs</b>: Linux Virtual Server.</para>
        /// </description></item>
        /// <item><description><para><b>proxy</b>: proxy server.</para>
        /// </description></item>
        /// <item><description><para><b>dns</b>: Domain Name System.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lvs</para>
        /// </summary>
        [NameInMap("DBInstanceConnType")]
        [Validation(Required=false)]
        public string DBInstanceConnType { get; set; }

        /// <summary>
        /// <para>The node specifications. For more information, see the following documents:</para>
        /// <list type="bullet">
        /// <item><description><para>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for PostgreSQL (Oracle Compatible): <a href="https://help.aliyun.com/document_detail/207921.html">Compute node specifications</a>.</para>
        /// </description></item>
        /// <item><description><para>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Compute node specifications</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x4.large</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for MySQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for PostgreSQL:</para>
        /// <list type="bullet">
        /// <item><description><para><b>11</b></para>
        /// </description></item>
        /// <item><description><para><b>14</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for Oracle:</para>
        /// <list type="bullet">
        /// <item><description><para><b>11</b></para>
        /// </description></item>
        /// <item><description><para><b>14</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the list of zones that support single-zone deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): The list is not returned.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The list is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a MaxScale cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): A MaxScale cluster is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: A MaxScale cluster is not created.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedMaxScaleLink")]
        [Validation(Required=false)]
        public string NeedMaxScaleLink { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
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
        /// <para>The subdomain. A subdomain is a level below a top-level domain. For example, if the parent domain is \<c>cn-beijing\\</c>, a valid subdomain is \<c>cn-beijing-i-aliyun\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i-aliyun</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the available zones.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
