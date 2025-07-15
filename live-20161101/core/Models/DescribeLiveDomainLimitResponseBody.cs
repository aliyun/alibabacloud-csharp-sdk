// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The limits.</para>
        /// </summary>
        [NameInMap("LiveDomainLimitList")]
        [Validation(Required=false)]
        public DescribeLiveDomainLimitResponseBodyLiveDomainLimitList LiveDomainLimitList { get; set; }
        public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitList : TeaModel {
            [NameInMap("LiveDomainLimit")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit> LiveDomainLimit { get; set; }
            public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit : TeaModel {
                /// <summary>
                /// <para>The current number of ingested streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentNum")]
                [Validation(Required=false)]
                public int? CurrentNum { get; set; }

                /// <summary>
                /// <para>The current number of transcoded streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentTranscodeNum")]
                [Validation(Required=false)]
                public int? CurrentTranscodeNum { get; set; }

                /// <summary>
                /// <para>The current number of streams relayed from the live center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentTransferNum")]
                [Validation(Required=false)]
                public int? CurrentTransferNum { get; set; }

                /// <summary>
                /// <para>The name of the queried main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The maximum number of ingested streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LimitNum")]
                [Validation(Required=false)]
                public int? LimitNum { get; set; }

                /// <summary>
                /// <para>The maximum number of transcoded streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("LimitTranscodeNum")]
                [Validation(Required=false)]
                public int? LimitTranscodeNum { get; set; }

                /// <summary>
                /// <para>The maximum allowed number of streams relayed from the live center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("LimitTransferNum")]
                [Validation(Required=false)]
                public int? LimitTransferNum { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
