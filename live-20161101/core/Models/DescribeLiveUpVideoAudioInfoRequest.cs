// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUpVideoAudioInfoRequest : TeaModel {
        /// <summary>
        /// <para>The end time. The format is \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T15:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. The format is \<c>yyyy-MM-ddTHH:mm:ssZ\\</c> in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The full name of the stream to query. The format is <c>rtmp://&lt;ingest domain&gt;/&lt;AppName&gt;/&lt;StreamName&gt;</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp://example.com/AppName/StreamName</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
