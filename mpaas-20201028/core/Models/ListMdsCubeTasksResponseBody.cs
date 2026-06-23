// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeTasksResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeTasksResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeTasksResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeTasksResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public List<ListMdsCubeTasksResponseBodyResultContentDataContent> Content { get; set; }
                public class ListMdsCubeTasksResponseBodyResultContentDataContent : TeaModel {
                    [NameInMap("AppCode")]
                    [Validation(Required=false)]
                    public string AppCode { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GreyConfigInfo")]
                    [Validation(Required=false)]
                    public string GreyConfigInfo { get; set; }

                    [NameInMap("GreyEndtimeData")]
                    [Validation(Required=false)]
                    public string GreyEndtimeData { get; set; }

                    [NameInMap("GreyNum")]
                    [Validation(Required=false)]
                    public int? GreyNum { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("PublishMode")]
                    [Validation(Required=false)]
                    public int? PublishMode { get; set; }

                    [NameInMap("PublishType")]
                    [Validation(Required=false)]
                    public int? PublishType { get; set; }

                    [NameInMap("ResourceVersion")]
                    [Validation(Required=false)]
                    public string ResourceVersion { get; set; }

                    [NameInMap("TaskDesc")]
                    [Validation(Required=false)]
                    public string TaskDesc { get; set; }

                    [NameInMap("TaskStatus")]
                    [Validation(Required=false)]
                    public int? TaskStatus { get; set; }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TemplateResourceId")]
                    [Validation(Required=false)]
                    public long? TemplateResourceId { get; set; }

                    [NameInMap("WhitelistIds")]
                    [Validation(Required=false)]
                    public string WhitelistIds { get; set; }

                }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
