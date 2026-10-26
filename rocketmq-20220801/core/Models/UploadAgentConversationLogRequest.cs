// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UploadAgentConversationLogRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H4sIAAAAAAAAEzMyMDLTNbDUNTQKMTSwMgAhbQMLKwMDBU8/N3+F4sq8kozUksxkheSczNS8EoWc/HSF4pLEohIuIwydhgR1pualcAEAN/JXaXIAAAA=</para>
        /// </summary>
        [NameInMap("contentGzipB64")]
        [Validation(Required=false)]
        public string ContentGzipB64 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client.log</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-12T11:00:00+08:00</para>
        /// </summary>
        [NameInMap("timeRangeEnd")]
        [Validation(Required=false)]
        public string TimeRangeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-12T10:00:00+08:00</para>
        /// </summary>
        [NameInMap("timeRangeStart")]
        [Validation(Required=false)]
        public string TimeRangeStart { get; set; }

    }

}
