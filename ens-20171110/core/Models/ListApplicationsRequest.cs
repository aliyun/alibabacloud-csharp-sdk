// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>The version number of the application. Separate multiple version numbers with commas (,). If you want to query data of all versions of applications, specify All for this parameter. By default, only data of applications in the stable versions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1,v2</para>
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        /// <summary>
        /// <para>The name of the application cluster. Separate multiple names with commas (,). If you want to query applications of all clusters in your account, specify All for this parameter. Default value: All.</para>
        /// 
        /// <b>Example:</b>
        /// <para>poc,pre</para>
        /// </summary>
        [NameInMap("ClusterNames")]
        [Validation(Required=false)]
        public string ClusterNames { get; set; }

        /// <summary>
        /// <para>The region level by which edge resources of the application are collected. The value is of the enumeration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>National: Chinese mainland</description></item>
        /// <item><description>Big: area</description></item>
        /// <item><description>Middle: province</description></item>
        /// <item><description>Small: city</description></item>
        /// <item><description>RegionId: edge node</description></item>
        /// </list>
        /// <para>Default value: National.</para>
        /// 
        /// <b>Example:</b>
        /// <para>National</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-20</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-15</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to return other information about the application, such as statistics on resource instances and pods. The value must be a JSON string. By default, all information is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appInfo\&quot;:true,\&quot;detailStat\&quot;: true, \&quot;appVersionStat\&quot;: true, \&quot;districtStat\&quot;:true ,\&quot;instanceStat\&quot;: true, \&quot;podCountStat\&quot;: true}</para>
        /// </summary>
        [NameInMap("OutAppInfoParams")]
        [Validation(Required=false)]
        public string OutAppInfoParams { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. This parameter is optional if you want to return the push status of all data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. This parameter is optional if you want to return all information about the applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
