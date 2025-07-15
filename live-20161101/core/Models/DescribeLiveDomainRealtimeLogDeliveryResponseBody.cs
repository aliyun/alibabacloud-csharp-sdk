// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the Logstore to which log entries are delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore_example</para>
        /// </summary>
        [NameInMap("Logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for real-time log delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_example</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Log Service project is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F8F3852-912F-42AC-80EB-F1CF4284DE93</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of real-time log delivery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: Real-time log delivery is enabled.</description></item>
        /// <item><description>offline: Real-time log delivery is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
