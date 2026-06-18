// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSeatInformationResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSeatInformationResponseBodyData Data { get; set; }
        public class GetSeatInformationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The information is a JSON string of the List<Map> type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tenant_id&quot;: &quot;905&quot;, &quot;tenant_name&quot;: &quot;非单元测试化BU&quot;, &quot;department_id&quot;: &quot;-1&quot;, &quot;svc_avai_capacity&quot;: 7,      &quot;svc_current_capacity&quot;: 0, &quot;department_name&quot;: &quot;-1&quot;,  &quot;svc_online_cnt&quot;: 3, &quot;svc_ask_offline_servicer_num&quot;: 0,      &quot;date_id&quot;: &quot;20210401&quot;,  &quot;svc_max_capacity&quot;: 7, &quot;svc_rest_cnt&quot;: 0, &quot;current_speci_ability_num&quot;: 0, &quot;servicer_rest_cnt&quot;: 122, &quot;max_speci_ability_num&quot;: 3,      &quot;svc_offline_cnt&quot;: 0,  &quot;svc_no_client_cnt&quot;: 3, &quot;svc_ask_rest_servicer_num&quot;: 0}</para>
            /// </summary>
            [NameInMap("Rowr")]
            [Validation(Required=false)]
            public string Rowr { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
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
