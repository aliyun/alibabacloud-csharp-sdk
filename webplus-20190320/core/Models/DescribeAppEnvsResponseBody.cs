// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeAppEnvsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AppEnvs")]
        [Validation(Required=false)]
        public DescribeAppEnvsResponseBodyAppEnvs AppEnvs { get; set; }
        public class DescribeAppEnvsResponseBodyAppEnvs : TeaModel {
            [NameInMap("AppEnv")]
            [Validation(Required=false)]
            public List<DescribeAppEnvsResponseBodyAppEnvsAppEnv> AppEnv { get; set; }
            public class DescribeAppEnvsResponseBodyAppEnvsAppEnv : TeaModel {
                public long? UpdateTime { get; set; }
                public long? TotalInstances { get; set; }
                public string PkgVersionStorageKey { get; set; }
                public string LatestChangeId { get; set; }
                public string EnvStatus { get; set; }
                public long? CreateTime { get; set; }
                public string LastEnvStatus { get; set; }
                public string PkgVersionId { get; set; }
                public string EnvDescription { get; set; }
                public bool? ApplyingChange { get; set; }
                public string EnvType { get; set; }
                public string AppName { get; set; }
                public string CreateUsername { get; set; }
                public string AppId { get; set; }
                public string DataRoot { get; set; }
                public string StorageBase { get; set; }
                public string UpdateUsername { get; set; }
                public string EnvName { get; set; }
                public string LogBase { get; set; }
                public string StackName { get; set; }
                public string CategoryName { get; set; }
                public bool? UsingSharedStorage { get; set; }
                public string ChangeBanner { get; set; }
                public string StackId { get; set; }
                public string PkgVersionLabel { get; set; }
                public string EnvId { get; set; }
                public bool? AbortingChange { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
