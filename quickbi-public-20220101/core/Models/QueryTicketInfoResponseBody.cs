// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryTicketInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryTicketInfoResponseBodyResult Result { get; set; }
        public class QueryTicketInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a27a9aec-<b><b>-</b></b>-bd40-1a21ea41d7c5</para>
            /// </summary>
            [NameInMap("AccessTicket")]
            [Validation(Required=false)]
            public string AccessTicket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sfdgsds-<b><b>-</b></b>-a608-mghdgd</para>
            /// </summary>
            [NameInMap("CmptId")]
            [Validation(Required=false)]
            public string CmptId { get; set; }

            [NameInMap("GlobalParam")]
            [Validation(Required=false)]
            public string GlobalParam { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-30 03:03:49</para>
            /// </summary>
            [NameInMap("InvalidTime")]
            [Validation(Required=false)]
            public string InvalidTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9999</para>
            /// </summary>
            [NameInMap("MaxTicketNum")]
            [Validation(Required=false)]
            public int? MaxTicketNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2fe4fbd8-<b><b>-</b></b>-b3e1-e92c7af083ea</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-09 22:23:49</para>
            /// </summary>
            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public string RegisterTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47</para>
            /// </summary>
            [NameInMap("UsedTicketNum")]
            [Validation(Required=false)]
            public int? UsedTicketNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>974e50**********9033f46</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WatermarkParam")]
            [Validation(Required=false)]
            public string WatermarkParam { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccd3428c-<b><b>-</b></b>-a608-26bae29dffee</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
