// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePullStreamConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the stream pulling configurations.</para>
        /// </summary>
        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeLivePullStreamConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLivePullStreamConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeLivePullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLivePullStreamConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
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
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The end of the time range for which the configurations were queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-05-20T01:33:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The origin server of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guide.aliyundoc.com</para>
                /// </summary>
                [NameInMap("SourceUrl")]
                [Validation(Required=false)]
                public string SourceUrl { get; set; }

                /// <summary>
                /// <para>The live stream origin server that you are using.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guide.aliyundoc.com</para>
                /// </summary>
                [NameInMap("SourceUsing")]
                [Validation(Required=false)]
                public string SourceUsing { get; set; }

                /// <summary>
                /// <para>The beginning of the time range for which the configurations were queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-05-15T01:30:00Z</para>
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

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
