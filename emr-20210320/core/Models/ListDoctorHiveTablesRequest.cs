// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHiveTablesRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The basis on which you want to sort the query results. Valid values:
        /// 
        /// *   partitionNum: the number of partitions.
        /// *   totalFileCount: the total number of files.
        /// *   largeFileCount: the number of large files. Large files are those with a size greater than 1 GB.
        /// *   mediumFileCount: the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
        /// *   smallFileCount: the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
        /// *   tinyFileCount: the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
        /// *   emptyFileCount: the number of empty files. Empty files are those with a size of 0 MB.
        /// *   largeFileRatio: the proportion of large files. Large files are those with a size greater than 1 GB.
        /// *   mediumFileRatio: the proportion of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
        /// *   smallFileRatio: the proportion of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
        /// *   tinyFileRatio: the proportion of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
        /// *   emptyFileRatio: the proportion of empty files. Empty files are those with a size of 0 MB.
        /// *   hotDataSize: the amount of hot data. Hot data refers to data that is accessed in previous seven days.
        /// *   WarmDataSize: the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.
        /// *   coldDataSize: the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.
        /// *   freezeDataSize: the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
        /// *   totalDataSize: the total amount of data.
        /// *   hotDataRatio: the proportion of hot data. Hot data refers to data that is accessed in previous seven days.
        /// *   WarmDataRatio: the proportion of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.
        /// *   coldDataRatio: the proportion of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.
        /// *   freezeDataRatio: the proportion of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
        /// *   totalFileDayGrowthCount: the daily increment of the total number of files.
        /// *   largeFileDayGrowthCount: the daily increment of the number of large files. Large files are those with a size greater than 1 GB.
        /// *   mediumFileDayGrowthCount: the daily increment of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
        /// *   smallFileDayGrowthCount: the daily increment of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
        /// *   tinyFileDayGrowthCount: the daily increment of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
        /// *   emptyFileDayGrowthCount: the daily increment of the number of empty files. Empty files are those with a size of 0 MB.
        /// *   hotDataDayGrowthSize: the daily increment of the amount of hot data. Hot data refers to data that is accessed in previous seven days.
        /// *   warmDataDayGrowthSize: the daily increment of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.
        /// *   coldDataDayGrowthSize: the daily increment of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.
        /// *   freezeDataDayGrowthSize: the daily increment of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
        /// *   totalDataDayGrowthSize: the daily increment of the amount of total data.
        /// *   totalFileCountDayGrowthRatio: the day-to-day growth rate of the total number of files.
        /// *   largeFileCountDayGrowthRatio: the day-to-day growth rate of the number of large files. Large files are those with a size greater than 1 GB.
        /// *   mediumFileCountDayGrowthRatio: the day-to-day growth rate of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
        /// *   smallFileCountDayGrowthRatio: the day-to-day growth rate of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
        /// *   tinyFileCountDayGrowthRatio: the day-to-day growth rate of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
        /// *   emptyFileCountDayGrowthRatio: the day-to-day growth rate of the number of empty files. Empty files are those with a size of 0 MB.
        /// *   hotDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of hot data. Hot data refers to data that is accessed in previous seven days.
        /// *   warmDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in previous 30 days.
        /// *   coldDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in previous 90 days.
        /// *   freezeDataSizeDayGrowthRatio: the day-to-day growth rate of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
        /// *   totalDataSizeDayGrowthRatio: the day-to-day growth rate of the total amount of data.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid value:
        /// 
        /// *   ASC: in ascending order
        /// *   DESC: in descending order
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The table names, which are used to filter the query results.
        /// </summary>
        [NameInMap("TableNames")]
        [Validation(Required=false)]
        public List<string> TableNames { get; set; }

    }

}
