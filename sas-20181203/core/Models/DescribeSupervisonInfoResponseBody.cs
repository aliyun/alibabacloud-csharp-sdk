// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSupervisonInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The system vulnerability scanning time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721134553000</para>
        /// </summary>
        [NameInMap("LatestScanTime")]
        [Validation(Required=false)]
        public long? LatestScanTime { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E10BAF1C-A6C5-51E2-866C-76D5922E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
