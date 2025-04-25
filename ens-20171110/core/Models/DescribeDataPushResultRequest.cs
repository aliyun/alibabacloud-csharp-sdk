// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e76f8985-7965-41fc-925b-9648bb6bf650</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the data file. Separate multiple names with commas (,). By default, all data files are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159828628258496/mirror_file/game-2553efe7-7bf8-40fb-a6e7-09c9c00a992a.tar</para>
        /// </summary>
        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public string DataNames { get; set; }

        /// <summary>
        /// <para>The version number of the data file. Separate multiple numbers with commas (,). By default, all versions of data files are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90396</para>
        /// </summary>
        [NameInMap("DataVersions")]
        [Validation(Required=false)]
        public string DataVersions { get; set; }

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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. This parameter is optional if you want to return the push status of all data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of ENS nodes. Separate multiple IDs with commas (,). By default, all ENS nodes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wuhan-telecom_unicom_cmcc-2,cn-jiaozuo-2</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

    }

}
