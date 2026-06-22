// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHDFSDirectoriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The date. The value is in the ISO 8601 format. For example, 2023-01-01 represents January 1, 2023.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01</para>
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// <para>The path of the directory. The directory depth cannot exceed five levels. If you do not specify this parameter, the analysis results of all directories are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/tmp/test</para>
        /// </summary>
        [NameInMap("DirPath")]
        [Validation(Required=false)]
        public string DirPath { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The property based on which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>totalFileCount: the total number of files.</para>
        /// </description></item>
        /// <item><description><para>largeFileCount: the number of large files. A large file is 1 GB or larger.</para>
        /// </description></item>
        /// <item><description><para>mediumFileCount: the number of medium-sized files. A medium-sized file is larger than 128 MB and smaller than 1 GB.</para>
        /// </description></item>
        /// <item><description><para>smallFileCount: the number of small files. A small file is larger than 10 MB and less than or equal to 128 MB.</para>
        /// </description></item>
        /// <item><description><para>tinyFileCount: the number of tiny files. A tiny file is larger than 0 MB and less than or equal to 10 MB.</para>
        /// </description></item>
        /// <item><description><para>emptyFileCount: the number of empty files. An empty file is 0 MB in size.</para>
        /// </description></item>
        /// <item><description><para>hotDataSize: the size of hot data. Hot data is data that was accessed in the last 7 days.</para>
        /// </description></item>
        /// <item><description><para>warmDataSize: the size of warm data. Warm data is data that was not accessed in the last 7 days but was accessed in the last 30 days.</para>
        /// </description></item>
        /// <item><description><para>coldDataSize: the size of cold data. Cold data is data that was not accessed in the last 30 days but was accessed in the last 90 days.</para>
        /// </description></item>
        /// <item><description><para>freezeDataSize: the size of freeze data. Freeze data is data that was not accessed in the last 90 days.</para>
        /// </description></item>
        /// <item><description><para>totalDataSize: the total data size.</para>
        /// </description></item>
        /// <item><description><para>totalFileDayGrowthCount: the daily increase in the total number of files.</para>
        /// </description></item>
        /// <item><description><para>largeFileDayGrowthCount: the daily increase in the number of large files. A large file is 1 GB or larger.</para>
        /// </description></item>
        /// <item><description><para>mediumFileDayGrowthCount: the daily increase in the number of medium-sized files. A medium-sized file is larger than 128 MB and smaller than 1 GB.</para>
        /// </description></item>
        /// <item><description><para>smallFileDayGrowthCount: the daily increase in the number of small files. A small file is larger than 10 MB and less than or equal to 128 MB.</para>
        /// </description></item>
        /// <item><description><para>tinyFileDayGrowthCount: the daily increase in the number of tiny files. A tiny file is larger than 0 MB and less than or equal to 10 MB.</para>
        /// </description></item>
        /// <item><description><para>emptyFileDayGrowthCount: the daily increase in the number of empty files. An empty file is 0 MB in size.</para>
        /// </description></item>
        /// <item><description><para>hotDataDayGrowthSize: the daily increase in the size of hot data. Hot data is data that was accessed in the last 7 days.</para>
        /// </description></item>
        /// <item><description><para>warmDataDayGrowthSize: the daily increase in the size of warm data. Warm data is data that was not accessed in the last 7 days but was accessed in the last 30 days.</para>
        /// </description></item>
        /// <item><description><para>coldDataDayGrowthSize: the daily increase in the size of cold data. Cold data is data that was not accessed in the last 30 days but was accessed in the last 90 days.</para>
        /// </description></item>
        /// <item><description><para>freezeDataDayGrowthSize: the daily increase in the size of freeze data. Freeze data is data that was not accessed in the last 90 days.</para>
        /// </description></item>
        /// <item><description><para>totalDataDayGrowthSize: the daily increase in the total data size.</para>
        /// </description></item>
        /// <item><description><para>totalFileCountDayGrowthRatio: the day-over-day growth ratio of the total number of files.</para>
        /// </description></item>
        /// <item><description><para>largeFileCountDayGrowthRatio: the day-over-day growth ratio of the number of large files. A large file is 1 GB or larger.</para>
        /// </description></item>
        /// <item><description><para>mediumFileCountDayGrowthRatio: the day-over-day growth ratio of the number of medium-sized files. A medium-sized file is larger than 128 MB and smaller than 1 GB.</para>
        /// </description></item>
        /// <item><description><para>smallFileCountDayGrowthRatio: the day-over-day growth ratio of the number of small files. A small file is larger than 10 MB and less than or equal to 128 MB.</para>
        /// </description></item>
        /// <item><description><para>tinyFileCountDayGrowthRatio: the day-over-day growth ratio of the number of tiny files. A tiny file is larger than 0 MB and less than or equal to 10 MB.</para>
        /// </description></item>
        /// <item><description><para>emptyFileCountDayGrowthRatio: the day-over-day growth ratio of the number of empty files. An empty file is 0 MB in size.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>smallFileCount</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending</para>
        /// </description></item>
        /// <item><description><para>DESC: descending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
