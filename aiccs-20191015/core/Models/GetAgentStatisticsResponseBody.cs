// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentStatisticsResponseBodyData Data { get; set; }
        public class GetAgentStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The data rows, which is a JSON string of the List<Map> type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;n_resttype_1&quot;:15,&quot;t_outcall_speak&quot;:829747,&quot;average_incoming_time&quot;:&quot;8451.29&quot;,&quot;n_resttype_3&quot;:0,&quot;minute_id&quot;:&quot;-1&quot;,&quot;n_conference_speak&quot;:0,&quot;n_resttype_2&quot;:0,&quot;n_resttype_5&quot;:0,&quot;n_resttype_4&quot;:0,&quot;n_resttype_7&quot;:0,&quot;n_resttype_6&quot;:0,&quot;n_resttype_9&quot;:0,&quot;n_resttype_8&quot;:0,&quot;n_outcall_dial&quot;:25,&quot;total_break_time&quot;:&quot;58555&quot;,&quot;n_internal_speak&quot;:0,&quot;n_send_step_transfer&quot;:7,&quot;n_consulted_internal_speak&quot;:0}</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
