// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster link type. The backend randomly selects the default value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lvs</b> :Linux virtual server</description></item>
        /// <item><description><b>proxy</b>: proxy server</description></item>
        /// <item><description><b>dns</b>: domain name system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lvs</para>
        /// </summary>
        [NameInMap("DBInstanceConnType")]
        [Validation(Required=false)]
        public string DBInstanceConnType { get; set; }

        /// <summary>
        /// <para>The specifications of the node. For information about node specifications, see the following topics:</para>
        /// <list type="bullet">
        /// <item><description>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Specifications of compute nodes</a></description></item>
        /// <item><description>PolarDB for Oracle: <a href="https://help.aliyun.com/document_detail/207921.html">Specifications of compute nodes</a></description></item>
        /// <item><description>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Specifications of compute nodes</a></description></item>
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
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
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
        /// <para>The version of the database engine</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values for the MySQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values for the PostgreSQL database engine:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b></description></item>
        /// <item><description><b>14</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid value for the Oracle database engine: <b>11</b></para>
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
        /// <para>Specifies whether to return the zones in which the single-zone deployment method is supported. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no value returned</description></item>
        /// <item><description><b>1</b>: returns the zones.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DispenseMode")]
        [Validation(Required=false)]
        public string DispenseMode { get; set; }

        /// <summary>
        /// <para>Specifies whether Maxscale is created. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
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
        /// <para>The subdomain. It is the child domain of the top-level domain name or parent domain. For example, if the parent domain name is cn-beijing, its child domain can be cn-beijing-i-aliyun.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available zones.</para>
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
