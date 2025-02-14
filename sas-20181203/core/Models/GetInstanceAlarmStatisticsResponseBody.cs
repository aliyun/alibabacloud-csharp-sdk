// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInstanceAlarmStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>Data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceAlarmStatisticsResponseBodyData Data { get; set; }
        public class GetInstanceAlarmStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Reminder alarm count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RemindCount")]
            [Validation(Required=false)]
            public int? RemindCount { get; set; }

            /// <summary>
            /// <para>Critical alarm count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SeriousCount")]
            [Validation(Required=false)]
            public int? SeriousCount { get; set; }

            /// <summary>
            /// <para>Suspicious alarm count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

        }

        /// <summary>
        /// <para>阿里云为该请求生成的唯一标识符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
