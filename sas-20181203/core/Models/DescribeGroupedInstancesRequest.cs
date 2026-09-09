// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the first page to return. Default value: <b>1</b>, which indicates that the query results are returned starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the asset group to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-01</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The filter condition for querying assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: queries assets by asset group.</description></item>
        /// <item><description><b>regionId</b>: queries assets by region.</description></item>
        /// <item><description><b>vpcInstanceId</b>: queries assets by virtual private cloud (VPC).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groupId</para>
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of assets to query. Set the value to <b>ecs</b>, which indicates Elastic Compute Service (ECS) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>Settings for whether to enable paged query. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Paged query is enabled.</description></item>
        /// <item><description><b>false</b>: Paged query is disabled. Paging is not performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NoPage")]
        [Validation(Required=false)]
        public bool? NoPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>20</b>, which indicates that 20 entries of asset information are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is added as a member of a resource folder for member accounts.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The edition-based filter condition for querying assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas_gte_advanced</b>: Advanced Edition or higher</description></item>
        /// <item><description><b>sas_gte_enterprise</b>: Enterprise Edition or higher</description></item>
        /// <item><description><b>sas_gt_basic</b>: paid edition</description></item>
        /// <item><description><b>sas_eq_advanced</b>: Advanced Edition</description></item>
        /// <item><description><b>sas_gt_anti_virus</b>: higher than Anti-virus Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas_gt_basic</para>
        /// </summary>
        [NameInMap("SaleVersionCheckCode")]
        [Validation(Required=false)]
        public string SaleVersionCheckCode { get; set; }

        /// <summary>
        /// <para>The server vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: non-cloud asset</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
        /// <item><description><b>8</b>: lightweight asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

        /// <summary>
        /// <para>The server vendors. Separate multiple vendors with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: non-cloud asset</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
        /// <item><description><b>8</b>: lightweight asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0,8</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public string Vendors { get; set; }

    }

}
