// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUpVideoAudioInfoRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stream that you want to query. Specify this parameter in the following format: <c>rtmp://Ingest domain/Application name/Stream name</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T15:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>DescribeLiveUpVideoAudioInfo</b>.</para>
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
