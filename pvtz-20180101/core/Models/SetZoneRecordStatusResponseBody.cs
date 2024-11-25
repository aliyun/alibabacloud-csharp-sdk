// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class SetZoneRecordStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the DNS record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>207541****</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39CB16E5-4180-49F2-A060-23C0ECEB80D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state of the DNS record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLE: The DNS record is enabled.</description></item>
        /// <item><description>DISABLE: The DNS record is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DISABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
