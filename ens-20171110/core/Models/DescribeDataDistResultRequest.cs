// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e76f8985-7965-41fc-925b-9648bb6bf650</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The data file names. This parameter is a filter condition. You can specify multiple names separated by commas (,). By default, all data files are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudgame-shanghai/deploy_app/20220215/1644895216305ACG_M21B-ota-1.1.2-D-0215.0628_V1_0002-pre-weiduan.zip</para>
        /// </summary>
        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public string DataNames { get; set; }

        /// <summary>
        /// <para>The data file version numbers. This parameter is a filter condition. You can specify multiple versions separated by commas (,). By default, all versions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4885</para>
        /// </summary>
        [NameInMap("DataVersions")]
        [Validation(Required=false)]
        public string DataVersions { get; set; }

        /// <summary>
        /// <para>The list of ENS edge zone IDs.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The list of edge instance IDs. This parameter is a filter condition. You can specify multiple IDs separated by commas (,). By default, all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-7ecpqvkicnchxccozrp,i-6ecpqvkicnchxccozrp</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The end date of the query in the format &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-01</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The start date of the query in the format &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. You do not need to specify this parameter when exporting all data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging queries. This parameter is not required when exporting all data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
