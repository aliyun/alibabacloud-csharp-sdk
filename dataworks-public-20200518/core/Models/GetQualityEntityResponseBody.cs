// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityEntityResponseBodyData> Data { get; set; }
        public class GetQualityEntityResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EntityLevel")]
            [Validation(Required=false)]
            public int? EntityLevel { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Followers")]
            [Validation(Required=false)]
            public string Followers { get; set; }

            [NameInMap("HasRelativeNode")]
            [Validation(Required=false)]
            public bool? HasRelativeNode { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MatchExpression")]
            [Validation(Required=false)]
            public string MatchExpression { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("RelativeNode")]
            [Validation(Required=false)]
            public string RelativeNode { get; set; }

            [NameInMap("Sql")]
            [Validation(Required=false)]
            public int? Sql { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("Task")]
            [Validation(Required=false)]
            public int? Task { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
