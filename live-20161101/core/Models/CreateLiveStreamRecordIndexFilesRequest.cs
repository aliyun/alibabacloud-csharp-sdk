// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveStreamRecordIndexFilesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. The value of this parameter must be the same as the application name in the ingest URL. Otherwise, the configuration does not take effect. If you want to match all applications, specify an asterisk (\*) as the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the index file. TS segments that are uploaded before the end time are included in the index file. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the end time. If you set this parameter to true, the system attempts to include one more TS segment. The created index file covers the entire time range that is specified by the StartTime and EndTime parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EndTimeIncluded")]
        [Validation(Required=false)]
        public bool? EndTimeIncluded { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveBucket****</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The endpoint of the OSS bucket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-oss-****.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The name of the recording that is stored in OSS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{AppName}/{StreamName}/{Date}/{Hour}/{Minute}_{Second}.m3u8</para>
        /// </summary>
        [NameInMap("OssObject")]
        [Validation(Required=false)]
        public string OssObject { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The start time of the index file. TS segments that are uploaded after the start time are included in the index file. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream. The value of this parameter must be the same as the stream name in the ingest URL. Otherwise, the configuration does not take effect. If you want to match all streams, specify an asterisk (\*) as the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
