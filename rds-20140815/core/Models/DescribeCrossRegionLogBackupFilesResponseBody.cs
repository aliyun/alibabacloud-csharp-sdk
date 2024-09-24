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

        /// <summary>
        /// <para>The cross-region log backup files.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionLogBackupFilesResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionLogBackupFilesResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// <para>The ID of the destination region within which the cross-region backup file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                /// <summary>
                /// <para>The external URL from which you can download the cross-region log backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsddrlog-zb.oss-cn-zhangjiakou.aliyuncs.com/xxxxx">http://rdsddrlog-zb.oss-cn-zhangjiakou.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("CrossDownloadLink")]
                [Validation(Required=false)]
                public string CrossDownloadLink { get; set; }

                /// <summary>
                /// <para>The internal URL from which you can download the cross-region log backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsddrlog-zb.oss-cn-zhangjiakou-internal.aliyuncs.com/xxxxx">http://rdsddrlog-zb.oss-cn-zhangjiakou-internal.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("CrossIntranetDownloadLink")]
                [Validation(Required=false)]
                public string CrossIntranetDownloadLink { get; set; }

                /// <summary>
                /// <para>The ID of the cross-region log backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14567</para>
                /// </summary>
                [NameInMap("CrossLogBackupId")]
                [Validation(Required=false)]
                public int? CrossLogBackupId { get; set; }

                /// <summary>
                /// <para>The size of the cross-region log backup file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5312836</para>
                /// </summary>
                [NameInMap("CrossLogBackupSize")]
                [Validation(Required=false)]
                public long? CrossLogBackupSize { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8161055</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// <para>The time when the URL expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-30T15:00:00Z</para>
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                /// <summary>
                /// <para>The start time of the cross-region log backup file. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-05-30T12:10:00Z</para>
                /// </summary>
                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                /// <summary>
                /// <para>The end time of the cross-region log backup file. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-05-30T20:10:00Z</para>
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// <para>The name of the cross-region log backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou_rm-bpxxxxx_7198739_mysql-bin.000230</para>
                /// </summary>
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
