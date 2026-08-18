// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeSuspEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response information returned by Meta.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSuspEventsResponseBodyData Data { get; set; }
        public class DescribeSuspEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeSuspEventsResponseBodyDataBody Body { get; set; }
            public class DescribeSuspEventsResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <para>The number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The current page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of records per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The request ID of Security Center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AD2345D1-A498-58AF-97C0-88940AF87CB7</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The security alert event information.</para>
                /// </summary>
                [NameInMap("SuspEvents")]
                [Validation(Required=false)]
                public List<DescribeSuspEventsResponseBodyDataBodySuspEvents> SuspEvents { get; set; }
                public class DescribeSuspEventsResponseBodyDataBodySuspEvents : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the alert is from offline analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Advanced")]
                    [Validation(Required=false)]
                    public bool? Advanced { get; set; }

                    /// <summary>
                    /// <para>The name of the alert event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reverse shell_China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China China.</para>
                    /// </summary>
                    [NameInMap("AlarmEventName")]
                    [Validation(Required=false)]
                    public string AlarmEventName { get; set; }

                    /// <summary>
                    /// <para>The display name of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Login with unusual location</para>
                    /// </summary>
                    [NameInMap("AlarmEventNameDisplay")]
                    [Validation(Required=false)]
                    public string AlarmEventNameDisplay { get; set; }

                    /// <summary>
                    /// <para>The event type of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unusual Logon</para>
                    /// </summary>
                    [NameInMap("AlarmEventType")]
                    [Validation(Required=false)]
                    public string AlarmEventType { get; set; }

                    /// <summary>
                    /// <para>The display name of the alerting event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unusual Logon</para>
                    /// </summary>
                    [NameInMap("AlarmEventTypeDisplay")]
                    [Validation(Required=false)]
                    public string AlarmEventTypeDisplay { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the alert event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8df914418f****</para>
                    /// </summary>
                    [NameInMap("AlarmUniqueInfo")]
                    [Validation(Required=false)]
                    public string AlarmUniqueInfo { get; set; }

                    /// <summary>
                    /// <para>The name of the application to which the alerting event belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dfield-cloud-service-prod</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether automatic defense is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoBreaking")]
                    [Validation(Required=false)]
                    public bool? AutoBreaking { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the alerting event is supported for online handling, such as quarantine. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanBeDealOnLine")]
                    [Validation(Required=false)]
                    public bool? CanBeDealOnLine { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the false positive marking can be unmarked. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanCancelFault")]
                    [Validation(Required=false)]
                    public bool? CanCancelFault { get; set; }

                    /// <summary>
                    /// <para>The cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c8c87dae64c9947269091f36cfa9adc87</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>Indicates whether critical event protection pattern is enabled for the server. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ContainHwMode")]
                    [Validation(Required=false)]
                    public bool? ContainHwMode { get; set; }

                    /// <summary>
                    /// <para>The container ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>95878ef8779fae3dd82126812edd910402fc550a72f9bce87e56a4435d018384</para>
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    /// <summary>
                    /// <para>The container image ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha256:2e5a3b0ae5f452b3cb458789a9a7542ef40035a84318469a8528c5e444db1****</para>
                    /// </summary>
                    [NameInMap("ContainerImageId")]
                    [Validation(Required=false)]
                    public string ContainerImageId { get; set; }

                    /// <summary>
                    /// <para>The container image name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>centos7_apache:v1.0.1</para>
                    /// </summary>
                    [NameInMap("ContainerImageName")]
                    [Validation(Required=false)]
                    public string ContainerImageName { get; set; }

                    /// <summary>
                    /// <para>The data source. You can ignore this field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>URL</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public string DataSource { get; set; }

                    /// <summary>
                    /// <para>The description of the impact of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>webshell</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The details of the alerting event.</para>
                    /// </summary>
                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsDetails> Details { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsDetails : TeaModel {
                        /// <summary>
                        /// <para>The display name of the alerting event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>login with unusual location</para>
                        /// </summary>
                        [NameInMap("NameDisplay")]
                        [Validation(Required=false)]
                        public string NameDisplay { get; set; }

                        /// <summary>
                        /// <para>The event type of the alerting event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The path where the alerting event occurred.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/etc/crontab</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <para>The display path where the alerting event occurred.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/etc/crontab</para>
                        /// </summary>
                        [NameInMap("ValueDisplay")]
                        [Validation(Required=false)]
                        public string ValueDisplay { get; set; }

                    }

                    /// <summary>
                    /// <para>The detection source. This is an invalid field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("DetectSource")]
                    [Validation(Required=false)]
                    public string DetectSource { get; set; }

                    /// <summary>
                    /// <para>Indicates whether cloud sandbox detection is supported. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DisplaySandboxResult")]
                    [Validation(Required=false)]
                    public bool? DisplaySandboxResult { get; set; }

                    /// <summary>
                    /// <para>The remarks of the alerting event.</para>
                    /// </summary>
                    [NameInMap("EventNotes")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsEventNotes> EventNotes { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsEventNotes : TeaModel {
                        /// <summary>
                        /// <para>The remark information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Note")]
                        [Validation(Required=false)]
                        public string Note { get; set; }

                        /// <summary>
                        /// <para>The ID of the remark record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2859481</para>
                        /// </summary>
                        [NameInMap("NoteId")]
                        [Validation(Required=false)]
                        public long? NoteId { get; set; }

                        /// <summary>
                        /// <para>The time when the event was recorded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-09-26 01:51:01</para>
                        /// </summary>
                        [NameInMap("NoteTime")]
                        [Validation(Required=false)]
                        public string NoteTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the alerting event. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EventStatus")]
                    [Validation(Required=false)]
                    public int? EventStatus { get; set; }

                    /// <summary>
                    /// <para>The child class of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>login_common_location</para>
                    /// </summary>
                    [NameInMap("EventSubType")]
                    [Validation(Required=false)]
                    public string EventSubType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the alerting event is associated with tracing information. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasTraceInfo")]
                    [Validation(Required=false)]
                    public bool? HasTraceInfo { get; set; }

                    /// <summary>
                    /// <para>The unique identity of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3178</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The unique identity of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ccdab289-9765-47ef-af50-ba6be09aacd6</para>
                    /// </summary>
                    [NameInMap("ImageUuid")]
                    [Validation(Required=false)]
                    public string ImageUuid { get; set; }

                    /// <summary>
                    /// <para>The ID of the asset instance affected by the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-9dp6dwsxdl9z5u1e2f****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nginx</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <para>The public IP address of the associated instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.137.3*.6</para>
                    /// </summary>
                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    /// <summary>
                    /// <para>The private network IP address of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.36.*6.149</para>
                    /// </summary>
                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    /// <summary>
                    /// <para>The K8s cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ce3c41ed427794a7bb3d9da4554fc8039</para>
                    /// </summary>
                    [NameInMap("K8sClusterId")]
                    [Validation(Required=false)]
                    public string K8sClusterId { get; set; }

                    /// <summary>
                    /// <para>The K8s cluster name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testName</para>
                    /// </summary>
                    [NameInMap("K8sClusterName")]
                    [Validation(Required=false)]
                    public string K8sClusterName { get; set; }

                    /// <summary>
                    /// <para>The K8s namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("K8sNamespace")]
                    [Validation(Required=false)]
                    public string K8sNamespace { get; set; }

                    /// <summary>
                    /// <para>The K8s node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp14a1ay8e0aa9t0****</para>
                    /// </summary>
                    [NameInMap("K8sNodeId")]
                    [Validation(Required=false)]
                    public string K8sNodeId { get; set; }

                    /// <summary>
                    /// <para>The K8s node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("K8sNodeName")]
                    [Validation(Required=false)]
                    public string K8sNodeName { get; set; }

                    /// <summary>
                    /// <para>The K8s pod name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>myapp-pod</para>
                    /// </summary>
                    [NameInMap("K8sPodName")]
                    [Validation(Required=false)]
                    public string K8sPodName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether large model analysis label is supported. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("LargeModel")]
                    [Validation(Required=false)]
                    public bool? LargeModel { get; set; }

                    /// <summary>
                    /// <para>The most recent time when the alerting event occurred.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-09-26 01:51:01</para>
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public string LastTime { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp of the last occurrence, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// <para>The risk level of the alerting event. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>remind</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <para>The status of the malicious behavior defense rule. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>open</para>
                    /// </summary>
                    [NameInMap("MaliciousRuleStatus")]
                    [Validation(Required=false)]
                    public string MaliciousRuleStatus { get; set; }

                    /// <summary>
                    /// <para>The collection of alerting event labels.</para>
                    /// </summary>
                    [NameInMap("MarkList")]
                    [Validation(Required=false)]
                    public List<string> MarkList { get; set; }

                    /// <summary>
                    /// <para>The advanced whitelist rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><b>1.</b>&amp;nbsp&amp;nbsppath&amp;nbsp&amp;nbspcontain&amp;nbsp&amp;nbsp232&amp;nbsp&amp;nbsp</para>
                    /// </summary>
                    [NameInMap("MarkMisRules")]
                    [Validation(Required=false)]
                    public string MarkMisRules { get; set; }

                    /// <summary>
                    /// <para>The full name of the alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Unusual Logon-Login with unusual location</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The time when the alerting event first occurred.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-09-26 01:51:01</para>
                    /// </summary>
                    [NameInMap("OccurrenceTime")]
                    [Validation(Required=false)]
                    public string OccurrenceTime { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp of the first occurrence, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("OccurrenceTimeStamp")]
                    [Validation(Required=false)]
                    public long? OccurrenceTimeStamp { get; set; }

                    /// <summary>
                    /// <para>The fault code of the alerting event operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>kill_and_quara.Success</para>
                    /// </summary>
                    [NameInMap("OperateErrorCode")]
                    [Validation(Required=false)]
                    public string OperateErrorCode { get; set; }

                    /// <summary>
                    /// <para>The remarks of the alerting event operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("OperateMsg")]
                    [Validation(Required=false)]
                    public string OperateMsg { get; set; }

                    /// <summary>
                    /// <para>The UNIX timestamp of the alerting event operation, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("OperateTime")]
                    [Validation(Required=false)]
                    public long? OperateTime { get; set; }

                    /// <summary>
                    /// <para>The required edition:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SaleVersion")]
                    [Validation(Required=false)]
                    public string SaleVersion { get; set; }

                    /// <summary>
                    /// <para>The IDs of the alerting events associated with this alerting event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>628978308</para>
                    /// </summary>
                    [NameInMap("SecurityEventIds")]
                    [Validation(Required=false)]
                    public string SecurityEventIds { get; set; }

                    /// <summary>
                    /// <para>The Alibaba Cloud account ID that generated the alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>124075**67406</para>
                    /// </summary>
                    [NameInMap("SourceAliUid")]
                    [Validation(Required=false)]
                    public long? SourceAliUid { get; set; }

                    /// <summary>
                    /// <para>The attack stage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;[&quot;authority_maintenance&quot;]&quot;</para>
                    /// </summary>
                    [NameInMap("Stages")]
                    [Validation(Required=false)]
                    public string Stages { get; set; }

                    /// <summary>
                    /// <para>The operation type supported by the alert:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AI.false_positive</para>
                    /// </summary>
                    [NameInMap("SupportOperateCode")]
                    [Validation(Required=false)]
                    public string SupportOperateCode { get; set; }

                    /// <summary>
                    /// <para>The display name of the attack stage.</para>
                    /// </summary>
                    [NameInMap("TacticItems")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsTacticItems> TacticItems { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsTacticItems : TeaModel {
                        /// <summary>
                        /// <para>The ATT&amp;CK tactic name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Malicious scripts-Malicious script code execution</para>
                        /// </summary>
                        [NameInMap("TacticDisplayName")]
                        [Validation(Required=false)]
                        public string TacticDisplayName { get; set; }

                        /// <summary>
                        /// <para>The ATT&amp;CK attack stage information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TA0042</para>
                        /// </summary>
                        [NameInMap("TacticId")]
                        [Validation(Required=false)]
                        public string TacticId { get; set; }

                    }

                    /// <summary>
                    /// <para>The unique key of the security alert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1dfbdf56c5343b63c4854d08ec20e067</para>
                    /// </summary>
                    [NameInMap("UniqueInfo")]
                    [Validation(Required=false)]
                    public string UniqueInfo { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the associated instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9A75F21D3993C0A2B094A4AB132890B2</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                /// <summary>
                /// <para>The total number of records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request is successful, a success message is returned. If the request fails, the failure reason is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67BD8435-6624-5484-A75D-170231B51615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values: true: Successful. false: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
