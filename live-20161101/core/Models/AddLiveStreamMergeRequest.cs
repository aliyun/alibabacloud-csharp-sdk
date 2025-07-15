// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamMergeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application that generates the output stream. The value must be the same as the application name in the ingest URL of the output stream. Otherwise, the configuration does not take effect. You cannot set the value to an asterisk (\*).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the stream mixing.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The interval between the start time and the end time must be within 7 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-29T01:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the application that generates the input primary stream. The value must be the same as the application name that is specified in the ingest URL of the primary stream. Otherwise, the configuration does not take effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app1</para>
        /// </summary>
        [NameInMap("InAppName1")]
        [Validation(Required=false)]
        public string InAppName1 { get; set; }

        /// <summary>
        /// <para>The name of the application that generates the input secondary stream. The value must be the same as the application name that is specified in the ingest URL of the secondary stream. Otherwise, the configuration does not take effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app2</para>
        /// </summary>
        [NameInMap("InAppName2")]
        [Validation(Required=false)]
        public string InAppName2 { get; set; }

        /// <summary>
        /// <para>The name of the input primary stream. The value must be the same as the stream name that is specified in the ingest URL of the primary stream. Otherwise, the configuration does not take effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InStream1</para>
        /// </summary>
        [NameInMap("InStreamName1")]
        [Validation(Required=false)]
        public string InStreamName1 { get; set; }

        /// <summary>
        /// <para>The name of the input secondary stream. The value must be the same as the stream name that is specified in the ingest URL of the secondary stream. Otherwise, the configuration does not take effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream2</para>
        /// </summary>
        [NameInMap("InStreamName2")]
        [Validation(Required=false)]
        public string InStreamName2 { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The streaming protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rtmp</b>: This is the default value.</description></item>
        /// <item><description><b>rtc</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the stream mixing.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the output stream. The value must be the same as the stream name in the ingest URL of the output stream. Otherwise, the configuration does not take effect. You cannot set the value to an asterisk (\*).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StreamName</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
