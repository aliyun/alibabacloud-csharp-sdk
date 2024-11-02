// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordInOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution result of the component action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;actionUuid&quot;: &quot;3896a25d-4967-493c-942e-4e60f27da1f7-xxxxx&quot;,
        ///     &quot;outputSummary&quot;: {
        ///         &quot;datalist&quot;: [
        ///             {
        ///                 &quot;a&quot;: &quot;a&quot;
        ///             }
        ///         ],
        ///         &quot;total_data_successful&quot;: 1,
        ///         &quot;total_data&quot;: 1,
        ///         &quot;total_exe_successful&quot;: 1,
        ///         &quot;total_exe&quot;: 1,
        ///         &quot;total_data_with_dup&quot;: 1,
        ///         &quot;status&quot;: true
        ///     },
        ///     &quot;outputSchema&quot;: {
        ///         &quot;a&quot;: &quot;String&quot;,
        ///         &quot;startTime&quot;: &quot;DateTime&quot;
        ///     },
        ///     &quot;inputParams&quot;: {
        ///         &quot;inputData&quot;: [
        ///             {
        ///                 &quot;outputFields&quot;: {
        ///                     &quot;a&quot;: &quot;a&quot;
        ///                 }
        ///             }
        ///         ],
        ///         &quot;totalSize&quot;: 1
        ///     },
        ///     &quot;startTime&quot;: &quot;2023-11-13 17:47:28.645&quot;,
        ///     &quot;taskName&quot;: &quot;92af3c79-1754-4646-9366-9ddbxxxxx&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InOutputInfo")]
        [Validation(Required=false)]
        public string InOutputInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>372D8B41-AF8D-573A-9B3F-0924950F241F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
