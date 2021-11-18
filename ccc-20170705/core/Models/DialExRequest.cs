// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class DialExRequest : TeaModel {
        [NameInMap("AnswerMode")]
        [Validation(Required=false)]
        public int? AnswerMode { get; set; }

        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("RoutPoint")]
        [Validation(Required=false)]
        public string RoutPoint { get; set; }

    }

}
