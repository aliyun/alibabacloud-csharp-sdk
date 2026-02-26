// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionLogBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-15T12:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionLogBackupFilesResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionLogBackupFilesResponseBodyItemsItem : TeaModel {
                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                [NameInMap("CrossDownloadLink")]
                [Validation(Required=false)]
                public string CrossDownloadLink { get; set; }

                [NameInMap("CrossIntranetDownloadLink")]
                [Validation(Required=false)]
                public string CrossIntranetDownloadLink { get; set; }

                [NameInMap("CrossLogBackupId")]
                [Validation(Required=false)]
                public int? CrossLogBackupId { get; set; }

                [NameInMap("CrossLogBackupSize")]
                [Validation(Required=false)]
                public long? CrossLogBackupSize { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of cross-region backup files on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAC241E8-28E6-49DA-BFB0-B2DD090885C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T12:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
