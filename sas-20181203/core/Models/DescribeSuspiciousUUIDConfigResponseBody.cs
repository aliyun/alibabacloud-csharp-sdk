// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousUUIDConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of servers on which proactive defense of the specified type takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6044DC07-86F1-5DDA-A611-EC578EA4EEE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers on which proactive defense of the specified type takes effect.</para>
        /// </summary>
        [NameInMap("UUIDList")]
        [Validation(Required=false)]
        public List<string> UUIDList { get; set; }

    }

}
