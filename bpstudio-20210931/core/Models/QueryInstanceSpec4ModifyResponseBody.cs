// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class QueryInstanceSpec4ModifyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;&quot;,
        ///     &quot;AuthAction&quot;: &quot;&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceSpec4ModifyResponseBodyData Data { get; set; }
        public class QueryInstanceSpec4ModifyResponseBodyData : TeaModel {
            [NameInMap("OptionalValues")]
            [Validation(Required=false)]
            public List<QueryInstanceSpec4ModifyResponseBodyDataOptionalValues> OptionalValues { get; set; }
            public class QueryInstanceSpec4ModifyResponseBodyDataOptionalValues : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Max")]
                [Validation(Required=false)]
                public double? Max { get; set; }

                [NameInMap("Min")]
                [Validation(Required=false)]
                public double? Min { get; set; }

                [NameInMap("Step")]
                [Validation(Required=false)]
                public double? Step { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>847C9D0A-BABD-589C-8A9C-6464409EDED9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
