// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListDataSetResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSetResponseBodyData Data { get; set; }
        public class ListDataSetResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListDataSetResponseBodyDataData> Data { get; set; }
            public class ListDataSetResponseBodyDataData : TeaModel {
                [NameInMap("AutoTranscoding")]
                [Validation(Required=false)]
                public int? AutoTranscoding { get; set; }

                [NameInMap("ChannelId0")]
                [Validation(Required=false)]
                public int? ChannelId0 { get; set; }

                [NameInMap("ChannelId1")]
                [Validation(Required=false)]
                public int? ChannelId1 { get; set; }

                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateType")]
                [Validation(Required=false)]
                public int? CreateType { get; set; }

                [NameInMap("DataSetType")]
                [Validation(Required=false)]
                public int? DataSetType { get; set; }

                [NameInMap("IsDelete")]
                [Validation(Required=false)]
                public int? IsDelete { get; set; }

                [NameInMap("RoleConfigProp")]
                [Validation(Required=false)]
                public string RoleConfigProp { get; set; }

                [NameInMap("RoleConfigStatus")]
                [Validation(Required=false)]
                public int? RoleConfigStatus { get; set; }

                [NameInMap("RoleConfigTask")]
                [Validation(Required=false)]
                public string RoleConfigTask { get; set; }

                [NameInMap("SetBucketName")]
                [Validation(Required=false)]
                public string SetBucketName { get; set; }

                [NameInMap("SetDomain")]
                [Validation(Required=false)]
                public string SetDomain { get; set; }

                [NameInMap("SetFolderName")]
                [Validation(Required=false)]
                public string SetFolderName { get; set; }

                [NameInMap("SetId")]
                [Validation(Required=false)]
                public long? SetId { get; set; }

                [NameInMap("SetName")]
                [Validation(Required=false)]
                public string SetName { get; set; }

                [NameInMap("SetNumber")]
                [Validation(Required=false)]
                public int? SetNumber { get; set; }

                [NameInMap("SetRoleArn")]
                [Validation(Required=false)]
                public string SetRoleArn { get; set; }

                [NameInMap("SetType")]
                [Validation(Required=false)]
                public int? SetType { get; set; }

                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public int? SourceDataType { get; set; }

                [NameInMap("SubDir")]
                [Validation(Required=false)]
                public string SubDir { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UserGroup")]
                [Validation(Required=false)]
                public string UserGroup { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public ListDataSetResponseBodyMessages Messages { get; set; }
        public class ListDataSetResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
