// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSkillGroupLatitudeStateResponseBody : TeaModel {
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
        public GetSkillGroupLatitudeStateResponseBodyData Data { get; set; }
        public class GetSkillGroupLatitudeStateResponseBodyData : TeaModel {
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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>A JSON string of type List<Map>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tenant_id&quot;:&quot;905&quot;,&quot;n_resttype_now&quot;:0,&quot;tenant_name&quot;:&quot;非单元测试化BU&quot;,&quot;n_resttype1_now&quot;:0,&quot;group_name&quot;:&quot;-1&quot;,&quot;department_id&quot;:&quot;-1&quot;,&quot;department_name&quot;:&quot;-1&quot;,&quot;n_resttype98_now&quot;:0,&quot;n_online_now&quot;:0,&quot;date_id&quot;:&quot;20210329&quot;,&quot;n_resttype3_now&quot;:0,&quot;n_resttype5_now&quot;:0,&quot;n_busy_now&quot;:0,&quot;n_resttype2_now&quot;:0,&quot;group_id&quot;:&quot;-1&quot;,&quot;n_idle_now&quot;:0,&quot;n_resttype4_now&quot;:0,&quot;n_ack_now&quot;:0,&quot;n_resttype99_now&quot;:0,&quot;maximumqueuingtime&quot;:-1}</para>
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
