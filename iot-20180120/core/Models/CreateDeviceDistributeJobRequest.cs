// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceDistributeJobRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

        [NameInMap("TargetAliyunId")]
        [Validation(Required=false)]
        public string TargetAliyunId { get; set; }

        [NameInMap("TargetInstanceConfig")]
        [Validation(Required=false)]
        public List<CreateDeviceDistributeJobRequestTargetInstanceConfig> TargetInstanceConfig { get; set; }
        public class CreateDeviceDistributeJobRequestTargetInstanceConfig : TeaModel {
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

        }

        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

    }

}
