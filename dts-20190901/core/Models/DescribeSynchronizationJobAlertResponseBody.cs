// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20190901.Models
{
    public class DescribeSynchronizationJobAlertResponseBody : TeaModel {
        [NameInMap("DelayAlertPhone")]
        [Validation(Required=false)]
        public string DelayAlertPhone { get; set; }

        [NameInMap("DelayAlertStatus")]
        [Validation(Required=false)]
        public string DelayAlertStatus { get; set; }

        [NameInMap("DelayOverSeconds")]
        [Validation(Required=false)]
        public string DelayOverSeconds { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("ErrorAlertPhone")]
        [Validation(Required=false)]
        public string ErrorAlertPhone { get; set; }

        [NameInMap("ErrorAlertStatus")]
        [Validation(Required=false)]
        public string ErrorAlertStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

    }

}
