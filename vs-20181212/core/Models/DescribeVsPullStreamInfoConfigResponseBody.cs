// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsPullStreamInfoConfigResponseBody : TeaModel {
        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeVsPullStreamInfoConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxApp</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-05-15T07:30:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://test">http://test</a></para>
                /// </summary>
                [NameInMap("SourceUrl")]
                [Validation(Required=false)]
                public string SourceUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-05-15T01:30:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxStream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
