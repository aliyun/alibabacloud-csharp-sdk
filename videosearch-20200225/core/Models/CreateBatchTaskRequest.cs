// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class CreateBatchTaskRequest : TeaModel {
        [NameInMap("BatchTaskType")]
        [Validation(Required=false)]
        public int? BatchTaskType { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssDataPath")]
        [Validation(Required=false)]
        public string OssDataPath { get; set; }

        [NameInMap("OssMetaFile")]
        [Validation(Required=false)]
        public string OssMetaFile { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
