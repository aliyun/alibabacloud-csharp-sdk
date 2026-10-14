// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultRequest : TeaModel {
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
        /// <para>The names of the data files. This is a filter condition for the query. Multiple values are supported and separated by commas (,). By default, all data files are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159828628258496/mirror_file/game-2553efe7-7bf8-40fb-a6e7-09c9c00a992a.tar</para>
        /// </summary>
        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public string DataNames { get; set; }

        /// <summary>
        /// <para>The version numbers of the data files. This is a filter condition for the query. Multiple values are supported and separated by commas (,). By default, all versions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90396</para>
        /// </summary>
        [NameInMap("DataVersions")]
        [Validation(Required=false)]
        public string DataVersions { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: YYYY-MM-DD. By default, there is no time limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-20</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: YYYY-MM-DD. By default, there is no time limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-15</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. This parameter is not required when you export all information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page set in Settings for paging during a paged query. This parameter is not required when you export all entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the edge nodes. This is a filter condition for the query. Multiple values are supported and separated by commas (,). By default, all edge nodes are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wuhan-telecom_unicom_cmcc-2,cn-jiaozuo-2</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

    }

}
