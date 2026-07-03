// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The source of the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>center</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>center</para>
        /// </summary>
        [NameInMap("DataSourceFrom")]
        [Validation(Required=false)]
        public string DataSourceFrom { get; set; }

        /// <summary>
        /// <para>The IDs of the data sources.</para>
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public string DataSourceIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_waf_alert_log</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The status of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>unconfigured</para>
        /// </description></item>
        /// <item><description><para>normal</para>
        /// </description></item>
        /// <item><description><para>abnormal</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>unconfigured</para>
        /// </summary>
        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        /// <summary>
        /// <para>The status of the Logstore. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>normal</para>
        /// </description></item>
        /// <item><description><para>abnormal</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DataSourceStoreStatus")]
        [Validation(Required=false)]
        public string DataSourceStoreStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the data source templates.</para>
        /// </summary>
        [NameInMap("DataSourceTemplateIds")]
        [Validation(Required=false)]
        public string DataSourceTemplateIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>preset</para>
        /// </description></item>
        /// <item><description><para>custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogProjectName")]
        [Validation(Required=false)]
        public string LogProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the log storage region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit-activity</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        /// <summary>
        /// <para>The IDs of the users who can access the data.</para>
        /// </summary>
        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public string LogUserIdsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this parameter to the value of NextToken that is returned in the response to the previous query. Leave this parameter empty for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc</para>
        /// </description></item>
        /// <item><description><para>asc</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The sorting field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Data Management Center of your threat analysis feature is located. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. You can use this parameter to switch the perspective to a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
