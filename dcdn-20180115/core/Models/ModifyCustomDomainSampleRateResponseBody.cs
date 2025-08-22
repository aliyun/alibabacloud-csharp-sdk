// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyCustomDomainSampleRateResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ModifyCustomDomainSampleRateResponseBodyContent> Content { get; set; }
        public class ModifyCustomDomainSampleRateResponseBodyContent : TeaModel {
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("ErrMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            [NameInMap("SampleRate")]
            [Validation(Required=false)]
            public float? SampleRate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
