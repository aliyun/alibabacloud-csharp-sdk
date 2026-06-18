// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentBasisStatusResponseBody : TeaModel {
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
        public GetAgentBasisStatusResponseBodyData Data { get; set; }
        public class GetAgentBasisStatusResponseBodyData : TeaModel {
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
            /// <para>{&quot;tenant_id&quot;:&quot;905&quot;,&quot;servicer_id&quot;:&quot;73****&quot;,&quot;tenant_name&quot;:&quot;测试&quot;,&quot;recordgmtmodified&quot;:&quot;2021-04-01 11:36:50&quot;,&quot;pk_id&quot;:&quot;7320372021****&quot;,&quot;statusstarttime&quot;:&quot;2021-04-01 11:36:50&quot;,&quot;recordgmtcreate&quot;:&quot;2021-04-01 10:06:24&quot;,&quot;department_id&quot;:&quot;94****&quot;,&quot;department_name&quot;:&quot;测试技能组&quot;,&quot;lstlogintime&quot;:&quot;2021-04-01 10:06:24&quot;,&quot;date_id&quot;:&quot;20210401&quot;,&quot;triggerreason&quot;:&quot;3&quot;,&quot;servicer_status&quot;:&quot;D&quot;,&quot;assignstatus&quot;:&quot;1&quot;,&quot;servicerreal_name&quot;:&quot;xx&quot;,&quot;servicerstatusname&quot;:&quot;签出&quot;,&quot;fstlogintime&quot;:&quot;2021-04-01 10:06:24&quot;,&quot;servicer_name&quot;:&quot;xx&quot;}</para>
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
        /// <para>Status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
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
        /// <para>Indicates whether the API was invoked successfully. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.  </description></item>
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
