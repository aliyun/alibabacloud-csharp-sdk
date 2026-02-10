// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLimitResponseBody : TeaModel {
        [NameInMap("LiveDomainLimitList")]
        [Validation(Required=false)]
        public DescribeLiveDomainLimitResponseBodyLiveDomainLimitList LiveDomainLimitList { get; set; }
        public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitList : TeaModel {
            [NameInMap("LiveDomainLimit")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit> LiveDomainLimit { get; set; }
            public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit : TeaModel {
                [NameInMap("CurrentNum")]
                [Validation(Required=false)]
                public int? CurrentNum { get; set; }

                [NameInMap("CurrentTranscodeNum")]
                [Validation(Required=false)]
                public int? CurrentTranscodeNum { get; set; }

                [NameInMap("CurrentTransferNum")]
                [Validation(Required=false)]
                public int? CurrentTransferNum { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("LimitNum")]
                [Validation(Required=false)]
                public int? LimitNum { get; set; }

                [NameInMap("LimitTranscodeNum")]
                [Validation(Required=false)]
                public int? LimitTranscodeNum { get; set; }

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
