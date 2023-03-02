// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDownloadDataJobRequest : TeaModel {
        [NameInMap("DownloadDataType")]
        [Validation(Required=false)]
        public string DownloadDataType { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("FileConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> FileConfig { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
