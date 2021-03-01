// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateHookConfigurationResponseBody : TeaModel {
        [NameInMap("HooksConfiguration")]
        [Validation(Required=false)]
        public List<UpdateHookConfigurationResponseBodyHooksConfiguration> HooksConfiguration { get; set; }
        public class UpdateHookConfigurationResponseBodyHooksConfiguration : TeaModel {
            [NameInMap("IgnoreFail")]
            [Validation(Required=false)]
            public bool? IgnoreFail { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
