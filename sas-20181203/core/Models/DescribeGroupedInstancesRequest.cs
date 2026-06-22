// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The page number from which query results start to be displayed. Default value: <b>1</b>, indicating that query results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the asset group to query. Fuzzy search is supported.</para>
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
        /// <item><description><b>groupId</b>: queries assets by group.</description></item>
        /// <item><description><b>regionId</b>: queries assets by region.</description></item>
        /// <item><description><b>vpcInstanceId</b>: queries assets by Virtual Private Cloud (VPC).</description></item>
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
        /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The type of assets to query. Fixed value: <b>ecs</b>, indicating Elastic Compute Service (ECS) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable paginated queries. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables paginated queries.</description></item>
        /// <item><description><b>false</b>: disables paginated queries.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NoPage")]
        [Validation(Required=false)]
        public bool? NoPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query. Default value: <b>20</b>, indicating that 20 entries of asset information are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The edition filter for querying assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas_gte_advanced</b>: Advanced edition or higher</description></item>
        /// <item><description><b>sas_gte_enterprise</b>: Enterprise edition or higher</description></item>
        /// <item><description><b>sas_gt_basic</b>: paid editions</description></item>
        /// <item><description><b>sas_eq_advanced</b>: Advanced edition only</description></item>
        /// <item><description><b>sas_gt_anti_virus</b>: editions higher than Anti-virus edition</description></item>
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
        /// <item><description><b>0</b>: Alibaba Cloud assets</description></item>
        /// <item><description><b>1</b>: non-cloud assets</description></item>
        /// <item><description><b>2</b>: IDC assets</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: assets from other cloud providers</description></item>
        /// <item><description><b>8</b>: lightweight assets</description></item>
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
        /// <item><description><b>0</b>: Alibaba Cloud assets</description></item>
        /// <item><description><b>1</b>: non-cloud assets</description></item>
        /// <item><description><b>2</b>: IDC assets</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: assets from other cloud providers</description></item>
        /// <item><description><b>8</b>: lightweight assets</description></item>
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
