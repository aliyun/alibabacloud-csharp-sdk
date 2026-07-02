// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAbnormalEventsCountResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAbnormalEventsCountResponseBodyData> Data { get; set; }
        public class GetAbnormalEventsCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of abnormal events.</para>
            /// </summary>
            [NameInMap("eventList")]
            [Validation(Required=false)]
            public List<string> EventList { get; set; }

            /// <summary>
            /// <para>Abnormal event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>health</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Count of abnormal event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

        /// <summary>
        /// <para>When success is false, this value is not empty, indicating a business error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>result: code=1 msg=(Request failed, status_code != 200)</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
