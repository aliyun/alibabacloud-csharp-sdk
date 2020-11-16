// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveASRConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=true)]
        public string StreamName { get; set; }

        [NameInMap("MnsTopic")]
        [Validation(Required=false)]
        public string MnsTopic { get; set; }

        [NameInMap("MnsRegion")]
        [Validation(Required=false)]
        public string MnsRegion { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("HttpCallbackURL")]
        [Validation(Required=false)]
        public string HttpCallbackURL { get; set; }

    }

}
