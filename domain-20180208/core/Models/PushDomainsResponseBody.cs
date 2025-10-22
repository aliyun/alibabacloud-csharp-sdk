// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class PushDomainsResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public PushDomainsResponseBodyModule Module { get; set; }
        public class PushDomainsResponseBodyModule : TeaModel {
            [NameInMap("FailedResults")]
            [Validation(Required=false)]
            public List<PushDomainsResponseBodyModuleFailedResults> FailedResults { get; set; }
            public class PushDomainsResponseBodyModuleFailedResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cdxuanfeng.cn</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NoPermission</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>connect timed out</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20250124100136aYCj4hdA</para>
            /// </summary>
            [NameInMap("OutBizId")]
            [Validation(Required=false)]
            public string OutBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21301203021303120201</para>
            /// </summary>
            [NameInMap("PushNo")]
            [Validation(Required=false)]
            public string PushNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;a.com&quot;,  &quot;b.com&quot;]</para>
            /// </summary>
            [NameInMap("SuccessDomains")]
            [Validation(Required=false)]
            public List<string> SuccessDomains { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F51977F9-2B40-462B-BCCD-CF5BB1E9DB56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
