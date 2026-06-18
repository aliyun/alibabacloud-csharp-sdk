// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSkillGroupServiceStatusResponseBody : TeaModel {
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
        /// <para>List of data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillGroupServiceStatusResponseBodyData Data { get; set; }
        public class GetSkillGroupServiceStatusResponseBodyData : TeaModel {
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
            /// <para>Page size. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Information in the form of a JSON string of type List<Map>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;online_40s_transfer_ready_cnt&quot;:382,&quot;minute_id&quot;:&quot;-1&quot;,&quot;online_unsatis_cnt&quot;:0,&quot;online_simple_cnt&quot;:0,&quot;average_queue_time&quot;:&quot;0.39&quot;,&quot;service_pickup&quot;:&quot;7752&quot;,&quot;online_service_time_len&quot;:220753,&quot;online_direct_give_up_len&quot;:1187,&quot;channel_instance_name&quot;:&quot;-1&quot;,&quot;servicer_id&quot;:&quot;-1&quot;,&quot;tenant_name&quot;:&quot;非单元测试化BU&quot;,&quot;group_name&quot;:&quot;-1&quot;,&quot;online_30s_transfer_ready_cnt&quot;:382}</para>
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
        /// <para>Indicates whether the API was invoked successfully. Valid values:</para>
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
