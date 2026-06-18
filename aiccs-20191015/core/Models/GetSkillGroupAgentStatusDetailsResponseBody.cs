// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSkillGroupAgentStatusDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A return value of 200 indicates that the request succeeded.</para>
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
        public GetSkillGroupAgentStatusDetailsResponseBodyData Data { get; set; }
        public class GetSkillGroupAgentStatusDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            /// <summary>
            /// <para>The number of items per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>A JSON string of type List<Map>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tenant_id&quot;: &quot;905&quot;, &quot;tenant_name&quot;: &quot;非单元测试化BU&quot;, &quot;department_id&quot;: &quot;-1&quot;, &quot;svc_avai_capacity&quot;: 7,      &quot;svc_current_capacity&quot;: 0, &quot;department_name&quot;: &quot;-1&quot;,  &quot;svc_online_cnt&quot;: 3, &quot;svc_ask_offline_servicer_num&quot;: 0,  &quot;date_id&quot;: &quot;20210401&quot;,  &quot;svc_max_capacity&quot;: 7, &quot;svc_rest_cnt&quot;: 0, &quot;current_speci_ability_num&quot;: 0, &quot;servicer_rest_cnt&quot;: 122, &quot;max_speci_ability_num&quot;: 3,      &quot;svc_offline_cnt&quot;: 0,  &quot;svc_no_client_cnt&quot;: 3, &quot;svc_ask_rest_servicer_num&quot;: 0}</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>Status code description.</para>
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
        /// <para>Indicates whether the API call succeeded. Valid values:</para>
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
