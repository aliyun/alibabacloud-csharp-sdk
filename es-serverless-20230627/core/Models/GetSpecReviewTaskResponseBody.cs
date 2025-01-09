// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetSpecReviewTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E310AC54-957A-5FD5-B85B-E972B2BDA8DE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSpecReviewTaskResponseBodyResult Result { get; set; }
        public class GetSpecReviewTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>代表资源一级ID的资源属性字段</para>
            /// 
            /// <b>Example:</b>
            /// <para>339</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;limiters&quot;: [
            ///                     {
            ///                          &quot;type&quot;: &quot;INDEX_QUOTA&quot;,
            ///                          &quot;maxValue&quot;: 500,
            ///                          &quot;immutable&quot;: false
            ///                     }
            ///                ]
            ///           }</para>
            /// </summary>
            [NameInMap("applyLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> ApplyLimiter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;appType&quot;: &quot;TRIAL&quot;,
            ///                &quot;cu&quot;: 4,
            ///                &quot;storage&quot;: 100
            ///           }</para>
            /// </summary>
            [NameInMap("applyQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> ApplyQuota { get; set; }

            [NameInMap("applyReason")]
            [Validation(Required=false)]
            public string ApplyReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;limiters&quot;: [
            ///                     {
            ///                          &quot;type&quot;: &quot;INDEX_QUOTA&quot;,
            ///                          &quot;maxValue&quot;: 500,
            ///                          &quot;immutable&quot;: false
            ///                     }
            ///                ]
            ///           }</para>
            /// </summary>
            [NameInMap("effectiveLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectiveLimiter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;appType&quot;: &quot;TRIAL&quot;,
            ///                &quot;cu&quot;: 4,
            ///                &quot;storage&quot;: 100
            ///           }</para>
            /// </summary>
            [NameInMap("effectiveQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectiveQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-30T06:28:07.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-30T06:28:07.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;limiters&quot;: [
            ///                     {
            ///                          &quot;type&quot;: &quot;INDEX_QUOTA&quot;,
            ///                          &quot;maxValue&quot;: 500,
            ///                          &quot;immutable&quot;: false
            ///                     }
            ///                ]
            ///           }</para>
            /// </summary>
            [NameInMap("oldLimiter")]
            [Validation(Required=false)]
            public Dictionary<string, object> OldLimiter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///                &quot;appType&quot;: &quot;TRIAL&quot;,
            ///                &quot;cu&quot;: 2,
            ///                &quot;storage&quot;: 1
            ///           }</para>
            /// </summary>
            [NameInMap("oldQuota")]
            [Validation(Required=false)]
            public Dictionary<string, object> OldQuota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QUOTA</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
