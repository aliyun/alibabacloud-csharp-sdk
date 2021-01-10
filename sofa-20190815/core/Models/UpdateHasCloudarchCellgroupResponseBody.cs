// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateHasCloudarchCellgroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public UpdateHasCloudarchCellgroupResponseBodyResultContent ResultContent { get; set; }
        public class UpdateHasCloudarchCellgroupResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public UpdateHasCloudarchCellgroupResponseBodyResultContentData Data { get; set; }
            public class UpdateHasCloudarchCellgroupResponseBodyResultContentData : TeaModel {
                [NameInMap("PropertiesJsonStr")]
                [Validation(Required=false)]
                public string PropertiesJsonStr { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("WorkspaceGroup")]
                [Validation(Required=false)]
                public string WorkspaceGroup { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("YunyouId")]
                [Validation(Required=false)]
                public string YunyouId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Elastic")]
                [Validation(Required=false)]
                public bool? Elastic { get; set; }

                [NameInMap("UidRange")]
                [Validation(Required=false)]
                public string UidRange { get; set; }

                [NameInMap("MarkUidRange")]
                [Validation(Required=false)]
                public string MarkUidRange { get; set; }

                [NameInMap("ElasticUidRange")]
                [Validation(Required=false)]
                public string ElasticUidRange { get; set; }

                [NameInMap("ElasticMarkUidRange")]
                [Validation(Required=false)]
                public string ElasticMarkUidRange { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Tenant")]
                [Validation(Required=false)]
                public string Tenant { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public UpdateHasCloudarchCellgroupResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class UpdateHasCloudarchCellgroupResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public UpdateHasCloudarchCellgroupResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class UpdateHasCloudarchCellgroupResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
