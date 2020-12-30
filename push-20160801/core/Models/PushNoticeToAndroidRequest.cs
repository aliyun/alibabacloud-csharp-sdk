// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushNoticeToAndroidRequest : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public string TargetValue { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("JobKey")]
        [Validation(Required=false)]
        public string JobKey { get; set; }

        [NameInMap("ExtParameters")]
        [Validation(Required=false)]
        public string ExtParameters { get; set; }

    }

}
