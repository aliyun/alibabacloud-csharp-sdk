// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The start time for querying the next record.</para>
        /// <remarks>
        /// <para>Only applicable to snapshot queries. Specify the time in the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format. The time must be in UTC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T11:00:00Z</para>
        /// </summary>
        [NameInMap("NextStartTime")]
        [Validation(Required=false)]
        public string NextStartTime { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// <remarks>
        /// <para>Only applicable to recording queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>Only applicable to recording queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para>Only applicable to recording queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of storage records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The end time of the storage record. The time is in the YYYY-MM-DDTHH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-23T18:33:48</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The format of the storage file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>mp4</description></item>
            /// <item><description>flv</description></item>
            /// <item><description>hls</description></item>
            /// <item><description>jpg</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hls</para>
            /// </summary>
            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            /// <summary>
            /// <para>The height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>The ID of the storage record.</para>
            /// <remarks>
            /// <para>Only applicable to recording queries.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2be2a673-6033-4874-b6f2-f2bc0a1*****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The OSS bucket of the storage file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_oss_bucket</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The OSS endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-qingdao.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <para>The OSS object of the storage file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>record/live/310*****007/2021-11-23-18-19-38_2021-11-23-18-33-48.m3u8</para>
            /// </summary>
            [NameInMap("OssObject")]
            [Validation(Required=false)]
            public string OssObject { get; set; }

            /// <summary>
            /// <para>The start time of the storage record. The time is in the YYYY-MM-DDTHH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-23T18:19:32</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The stream ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323*****997-cn-qingdao</para>
            /// </summary>
            [NameInMap("StreamId")]
            [Validation(Required=false)]
            public string StreamId { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>388*****204-cn-qingdao</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the storage record. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>record: recording</description></item>
            /// <item><description>snapshot: snapshot</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>record</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the storage file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://my_oss_bucket.oss-cn-qingdao.aliyuncs.com/record/live/310*****007/2021-11-23-18-19-38_2021-11-23-18-33-48.m3u8">http://my_oss_bucket.oss-cn-qingdao.aliyuncs.com/record/live/310*****007/2021-11-23-18-19-38_2021-11-23-18-33-48.m3u8</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of storage records.</para>
        /// <remarks>
        /// <para>Only applicable to recording queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
