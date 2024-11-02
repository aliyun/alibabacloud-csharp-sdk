// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordActionOutputListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data that is returned when the component action is performed. The value is a JSON array.</para>
        /// <remarks>
        /// <para> The format of the output data is determined by the component that is configured when the playbook is written.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;a&quot;: &quot;a&quot;,
        ///         &quot;taskname&quot;: &quot;92af3c79-1754-4646-9366-9ddbd1e45536_xxxx&quot;,
        ///         &quot;log_time&quot;: 1699868849000
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("ActionOutputs")]
        [Validation(Required=false)]
        public string ActionOutputs { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A2BF9CF-3E32-5E45-A79B-8F67E0A4FE90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
