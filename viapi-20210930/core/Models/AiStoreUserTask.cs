// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi20210930.Models
{
    public class AiStoreUserTask : TeaModel {
        [NameInMap("ApiDesc")]
        [Validation(Required=false)]
        public string ApiDesc { get; set; }

        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("BucketKeyPrefix")]
        [Validation(Required=false)]
        public string BucketKeyPrefix { get; set; }

        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("DisableTime")]
        [Validation(Required=false)]
        public string DisableTime { get; set; }

        [NameInMap("EnableTime")]
        [Validation(Required=false)]
        public string EnableTime { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ParamInfo")]
        [Validation(Required=false)]
        public string ParamInfo { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("ProductDesc")]
        [Validation(Required=false)]
        public string ProductDesc { get; set; }

        [NameInMap("ReceiveConfig")]
        [Validation(Required=false)]
        public string ReceiveConfig { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionDesc")]
        [Validation(Required=false)]
        public string RegionDesc { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TaskVersion")]
        [Validation(Required=false)]
        public string TaskVersion { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
