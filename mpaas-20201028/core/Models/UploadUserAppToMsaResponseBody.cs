// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class UploadUserAppToMsaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public UploadUserAppToMsaResponseBodyResultContent ResultContent { get; set; }
        public class UploadUserAppToMsaResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public UploadUserAppToMsaResponseBodyResultContentData Data { get; set; }
            public class UploadUserAppToMsaResponseBodyResultContentData : TeaModel {
                [NameInMap("ApkInfo")]
                [Validation(Required=false)]
                public UploadUserAppToMsaResponseBodyResultContentDataApkInfo ApkInfo { get; set; }
                public class UploadUserAppToMsaResponseBodyResultContentDataApkInfo : TeaModel {
                    [NameInMap("AfterMd5")]
                    [Validation(Required=false)]
                    public string AfterMd5 { get; set; }

                    [NameInMap("AfterSize")]
                    [Validation(Required=false)]
                    public long? AfterSize { get; set; }

                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("AppPackage")]
                    [Validation(Required=false)]
                    public string AppPackage { get; set; }

                    [NameInMap("BeforeMd5")]
                    [Validation(Required=false)]
                    public string BeforeMd5 { get; set; }

                    [NameInMap("BeforeSize")]
                    [Validation(Required=false)]
                    public long? BeforeSize { get; set; }

                    [NameInMap("ClassForest")]
                    [Validation(Required=false)]
                    public string ClassForest { get; set; }

                    [NameInMap("EnhanceMapping")]
                    [Validation(Required=false)]
                    public UploadUserAppToMsaResponseBodyResultContentDataApkInfoEnhanceMapping EnhanceMapping { get; set; }
                    public class UploadUserAppToMsaResponseBodyResultContentDataApkInfoEnhanceMapping : TeaModel {
                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public string Info { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("EnhanceRules")]
                    [Validation(Required=false)]
                    public List<string> EnhanceRules { get; set; }

                    [NameInMap("EnhancedClasses")]
                    [Validation(Required=false)]
                    public List<string> EnhancedClasses { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public long? Progress { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("TaskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                    [NameInMap("VersionCode")]
                    [Validation(Required=false)]
                    public string VersionCode { get; set; }

                    [NameInMap("VersionName")]
                    [Validation(Required=false)]
                    public string VersionName { get; set; }

                }

                [NameInMap("EnhanceTaskId")]
                [Validation(Required=false)]
                public long? EnhanceTaskId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public long? Progress { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
