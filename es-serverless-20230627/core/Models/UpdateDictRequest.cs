// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateDictRequest : TeaModel {
        [NameInMap("allowCover")]
        [Validation(Required=false)]
        public bool? AllowCover { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<UpdateDictRequestFiles> Files { get; set; }
        public class UpdateDictRequestFiles : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ossObject")]
            [Validation(Required=false)]
            public UpdateDictRequestFilesOssObject OssObject { get; set; }
            public class UpdateDictRequestFilesOssObject : TeaModel {
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
