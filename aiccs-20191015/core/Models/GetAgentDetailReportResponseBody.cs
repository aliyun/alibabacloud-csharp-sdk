// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentDetailReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAgentDetailReportResponseBodyData Data { get; set; }
        public class GetAgentDetailReportResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;t_wait&quot;:379322.0,&quot;hotline_time_outcall_avg&quot;:&quot;32.00&quot;,&quot;n_ringing&quot;:0,&quot;t_outbound_40&quot;:0.0,&quot;hotline_time_incall_avg&quot;:-1,&quot;t_calldialing&quot;:0.0,&quot;n_inbound&quot;:276,&quot;servicer_id&quot;:&quot;-1&quot;,&quot;call_in_sep_sat_cnt&quot;:13,&quot;request_cnt&quot;:231,&quot;n_not_ready_99&quot;:811,&quot;t_work_outbound&quot;:49338.0,&quot;hotline_rate_handle_in_60s&quot;:&quot;96%&quot;,&quot;n_not_ready_login&quot;:811,&quot;t_not_ready_login&quot;:0.0,&quot;n_work_inbound&quot;:176,&quot;}</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
