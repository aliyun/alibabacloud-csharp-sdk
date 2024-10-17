// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHiveTablesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01</para>
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

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
        /// <para>The pagination token that is used in the request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The basis on which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>partitionNum: the number of partitions.</description></item>
        /// <item><description>totalFileCount: the total number of files.</description></item>
        /// <item><description>largeFileCount: the number of large files. Large files are those with a size greater than 1 GB.</description></item>
        /// <item><description>mediumFileCount: the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</description></item>
        /// <item><description>smallFileCount: the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</description></item>
        /// <item><description>tinyFileCount: the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</description></item>
        /// <item><description>emptyFileCount: the number of empty files. Empty files are those with a size of 0 MB.</description></item>
        /// <item><description>largeFileRatio: the proportion of large files. Large files are those with a size greater than 1 GB.</description></item>
        /// <item><description>mediumFileRatio: the proportion of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</description></item>
        /// <item><description>smallFileRatio: the proportion of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</description></item>
        /// <item><description>tinyFileRatio: the proportion of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</description></item>
        /// <item><description>emptyFileRatio: the proportion of empty files. Empty files are those with a size of 0 MB.</description></item>
        /// <item><description>hotDataSize: the amount of hot data. Hot data refers to data that is accessed in previous seven days.</description></item>
        /// <item><description>WarmDataSize: the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.</description></item>
        /// <item><description>coldDataSize: the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.</description></item>
        /// <item><description>freezeDataSize: the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</description></item>
        /// <item><description>totalDataSize: the total amount of data.</description></item>
        /// <item><description>hotDataRatio: the proportion of hot data. Hot data refers to data that is accessed in previous seven days.</description></item>
        /// <item><description>WarmDataRatio: the proportion of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.</description></item>
        /// <item><description>coldDataRatio: the proportion of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.</description></item>
        /// <item><description>freezeDataRatio: the proportion of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</description></item>
        /// <item><description>totalFileDayGrowthCount: the daily increment of the total number of files.</description></item>
        /// <item><description>largeFileDayGrowthCount: the daily increment of the number of large files. Large files are those with a size greater than 1 GB.</description></item>
        /// <item><description>mediumFileDayGrowthCount: the daily increment of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</description></item>
        /// <item><description>smallFileDayGrowthCount: the daily increment of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</description></item>
        /// <item><description>tinyFileDayGrowthCount: the daily increment of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</description></item>
        /// <item><description>emptyFileDayGrowthCount: the daily increment of the number of empty files. Empty files are those with a size of 0 MB.</description></item>
        /// <item><description>hotDataDayGrowthSize: the daily increment of the amount of hot data. Hot data refers to data that is accessed in previous seven days.</description></item>
        /// <item><description>warmDataDayGrowthSize: the daily increment of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.</description></item>
        /// <item><description>coldDataDayGrowthSize: the daily increment of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.</description></item>
        /// <item><description>freezeDataDayGrowthSize: the daily increment of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</description></item>
        /// <item><description>totalDataDayGrowthSize: the daily increment of the amount of total data.</description></item>
        /// <item><description>totalFileCountDayGrowthRatio: the day-to-day growth rate of the total number of files.</description></item>
        /// <item><description>largeFileCountDayGrowthRatio: the day-to-day growth rate of the number of large files. Large files are those with a size greater than 1 GB.</description></item>
        /// <item><description>mediumFileCountDayGrowthRatio: the day-to-day growth rate of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</description></item>
        /// <item><description>smallFileCountDayGrowthRatio: the day-to-day growth rate of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</description></item>
        /// <item><description>tinyFileCountDayGrowthRatio: the day-to-day growth rate of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</description></item>
        /// <item><description>emptyFileCountDayGrowthRatio: the day-to-day growth rate of the number of empty files. Empty files are those with a size of 0 MB.</description></item>
        /// <item><description>hotDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of hot data. Hot data refers to data that is accessed in previous seven days.</description></item>
        /// <item><description>warmDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.</description></item>
        /// <item><description>coldDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.</description></item>
        /// <item><description>freezeDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</description></item>
        /// <item><description>totalDataSizeDayGrowthRatio: the day-to-day growth rate of the total amount of data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>totalFileCount</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>ASC: in ascending order</description></item>
        /// <item><description>DESC: in descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The table names, which are used to filter the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public List<string> TableNames { get; set; }

    }

}
