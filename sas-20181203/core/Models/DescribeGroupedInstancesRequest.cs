// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the group to which the assets belong. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-01</para>
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// <para>The filter condition that you want to use to query the assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: the group to which the assets belong</description></item>
        /// <item><description><b>regionId</b>: the region in which the assets reside</description></item>
        /// <item><description><b>vpcInstanceId</b>: the virtual private cloud (VPC) in which the assets reside</description></item>
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
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The type of the assets that you want to query. Set the value to <b>ecs</b>, which indicates Elastic Compute Service (ECS) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable paged query. Default value: <b>true</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NoPage")]
        [Validation(Required=false)]
        public bool? NoPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The edition of Security Center that protects the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas_gte_advanced</b>: the Advanced edition or higher</description></item>
        /// <item><description><b>sas_gte_enterprise</b>: the Enterprise edition or higher</description></item>
        /// <item><description><b>sas_gt_basic:</b> a paid edition</description></item>
        /// <item><description><b>sas_eq_advanced:</b> the Advanced edition</description></item>
        /// <item><description><b>sas_gt_anti_virus:</b> an edition higher than the Anti-virus edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas_gt_basic</para>
        /// </summary>
        [NameInMap("SaleVersionCheckCode")]
        [Validation(Required=false)]
        public string SaleVersionCheckCode { get; set; }

        /// <summary>
        /// <para>The source of the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
        /// <item><description><b>1</b>: a third-party cloud server</description></item>
        /// <item><description><b>2</b>: a server in a data center</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
        /// <item><description><b>8</b>: a lightweight asset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

        /// <summary>
        /// <para>The source of the server. Separate multiple sources with commas (,).Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
        /// <item><description><b>1</b>: a third-party cloud server</description></item>
        /// <item><description><b>2</b>: a server in a data center</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
        /// <item><description><b>8</b>: a lightweight asset</description></item>
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
