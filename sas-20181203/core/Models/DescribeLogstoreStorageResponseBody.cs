// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogstoreStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the dedicated Logstore in which full logs of Security Center are stored. The value is fixed as <b>sas-log</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-log</para>
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The purchased log analysis storage capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12240</para>
        /// </summary>
        [NameInMap("Preserve")]
        [Validation(Required=false)]
        public long? Preserve { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25EC270F-5783-4416-AD7C-1EDF063A039C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of days for which logs are retained. The value is fixed as <b>180</b>, which indicates that logs can be retained for 180 days.</para>
        /// <remarks>
        /// <para>Security Center does not support adjusting the log retention period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The used log analysis storage capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>335</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

        /// <summary>
        /// <para>The name of the dedicated Project in which full logs of Security Center are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-log-XXXX-cn-hangzhou</para>
        /// </summary>
        [NameInMap("UserProject")]
        [Validation(Required=false)]
        public string UserProject { get; set; }

    }

}
