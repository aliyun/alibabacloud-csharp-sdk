// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSuspiciousStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of alerts whose Emergency level is Reminder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RemindCount")]
        [Validation(Required=false)]
        public int? RemindCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84092B42-1A59-4F34-8DF8-1D93520990A5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of alerts whose Emergency level is Urgent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SeriousCount")]
        [Validation(Required=false)]
        public int? SeriousCount { get; set; }

        /// <summary>
        /// <para>The number of alerts whose Emergency level is Suspicious.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SuspiciousCount")]
        [Validation(Required=false)]
        public int? SuspiciousCount { get; set; }

        /// <summary>
        /// <para>The total number of alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
