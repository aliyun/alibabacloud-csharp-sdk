// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveStreamRecordIndexFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The recording configuration.</para>
        /// </summary>
        [NameInMap("RecordInfo")]
        [Validation(Required=false)]
        public CreateLiveStreamRecordIndexFilesResponseBodyRecordInfo RecordInfo { get; set; }
        public class CreateLiveStreamRecordIndexFilesResponseBodyRecordInfo : TeaModel {
            /// <summary>
            /// <para>The name of the application to which the live stream belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The time when the index file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-05-27T09:40:56Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The recording length. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The end time of the index file. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-12-01T07:40:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The height of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveBucket****</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The endpoint of the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-oss-****.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            /// <summary>
            /// <para>The name of the recording that is stored in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveObject****.m3u8</para>
            /// </summary>
            [NameInMap("OssObject")]
            [Validation(Required=false)]
            public string OssObject { get; set; }

            /// <summary>
            /// <para>The ID of the index file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <para>The URL of the M3U8 index file.</para>
            /// </summary>
            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }

            /// <summary>
            /// <para>The start time of the index file. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-12-01T07:36:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveStream****</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            /// <summary>
            /// <para>The width of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550439A3-F8EC-4CA2-BB62-B9DB43EEEF30</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
