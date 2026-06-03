// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListSystemAlarmsResponseBody : TeaModel {
        [NameInMap("Alarms")]
        [Validation(Required=false)]
        public List<ListSystemAlarmsResponseBodyAlarms> Alarms { get; set; }
        public class ListSystemAlarmsResponseBodyAlarms : TeaModel {
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public string AlarmDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1****</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public int? AlarmId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 05:03:17</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReadMark")]
            [Validation(Required=false)]
            public int? ReadMark { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
