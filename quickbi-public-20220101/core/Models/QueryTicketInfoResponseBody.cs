// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryTicketInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the generated ticket.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryTicketInfoResponseBodyResult Result { get; set; }
        public class QueryTicketInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Notes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a27a9aec-<b><b>-</b></b>-bd40-1a21ea41d7c5</para>
            /// </summary>
            [NameInMap("AccessTicket")]
            [Validation(Required=false)]
            public string AccessTicket { get; set; }

            /// <summary>
            /// <para>The ID of the component in the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sfdgsds-<b><b>-</b></b>-a608-mghdgd</para>
            /// </summary>
            [NameInMap("CmptId")]
            [Validation(Required=false)]
            public string CmptId { get; set; }

            /// <summary>
            /// <para>Global parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&amp;{quot;paramKey\&quot;:\&quot;price\&quot;,\&quot;joinType\&quot;and\&quot;,\&quot;conditionList\&quot;:[{\&quot; operation\&quot;\&quot;\&quot;\&quot;\&quot;\&quot;\&quot;value ;&amp; quot;\&quot;\&quot;\&quot;\&quot;\&quot;\&quot;\&quot;\&quot;\&amp;quot product_type\&quot;,\&quot;joinType\&quot;:\&quot;and &quot;;,&amp; quot;conditionList\&quot;, the conditions must be:[{\&quot;operate&quot; ;:&amp; quot;in\&quot;,\&quot;value\&quot;, the conditions must be:[\&quot; office supplies\&quot;,\&quot; furniture products\&quot;]}]}]\n</para>
            /// </summary>
            [NameInMap("GlobalParam")]
            [Validation(Required=false)]
            public string GlobalParam { get; set; }

            /// <summary>
            /// <para>Expiration time of the note.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-30 03:03:49</para>
            /// </summary>
            [NameInMap("InvalidTime")]
            [Validation(Required=false)]
            public string InvalidTime { get; set; }

            /// <summary>
            /// <para>The maximum number of supported bills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("MaxTicketNum")]
            [Validation(Required=false)]
            public int? MaxTicketNum { get; set; }

            /// <summary>
            /// <para>The ID of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2fe4fbd8-<b><b>-</b></b>-b3e1-e92c7af083ea</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The registration time of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-09 22:23:49</para>
            /// </summary>
            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public string RegisterTime { get; set; }

            /// <summary>
            /// <para>The number of bills that have been consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("UsedTicketNum")]
            [Validation(Required=false)]
            public int? UsedTicketNum { get; set; }

            /// <summary>
            /// <para>The user ID of the Quick BI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>974e50**********9033f46</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Set the watermarking parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tripartite embedding of Ticket</para>
            /// </summary>
            [NameInMap("WatermarkParam")]
            [Validation(Required=false)]
            public string WatermarkParam { get; set; }

            /// <summary>
            /// <para>The ID of the operations report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccd3428c-<b><b>-</b></b>-a608-26bae29dffee</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
