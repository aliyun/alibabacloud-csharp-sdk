// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetHostGroupResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("hostGroup")]
        [Validation(Required=false)]
        public GetHostGroupResponseBodyHostGroup HostGroup { get; set; }
        public class GetHostGroupResponseBodyHostGroup : TeaModel {
            [NameInMap("aliyunRegion")]
            [Validation(Required=false)]
            public string AliyunRegion { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ecsLabelKey")]
            [Validation(Required=false)]
            public string EcsLabelKey { get; set; }

            [NameInMap("ecsLabelValue")]
            [Validation(Required=false)]
            public string EcsLabelValue { get; set; }

            [NameInMap("ecsType")]
            [Validation(Required=false)]
            public string EcsType { get; set; }

            [NameInMap("hostInfos")]
            [Validation(Required=false)]
            public List<GetHostGroupResponseBodyHostGroupHostInfos> HostInfos { get; set; }
            public class GetHostGroupResponseBodyHostGroupHostInfos : TeaModel {
                [NameInMap("aliyunRegionId")]
                [Validation(Required=false)]
                public string AliyunRegionId { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("creatorAccountId")]
                [Validation(Required=false)]
                public string CreatorAccountId { get; set; }

                [NameInMap("instanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("machineSn")]
                [Validation(Required=false)]
                public string MachineSn { get; set; }

                [NameInMap("modifierAccountId")]
                [Validation(Required=false)]
                public string ModifierAccountId { get; set; }

                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("hostNum")]
            [Validation(Required=false)]
            public long? HostNum { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("serviceConnectionId")]
            [Validation(Required=false)]
            public long? ServiceConnectionId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("upateTIme")]
            [Validation(Required=false)]
            public long? UpateTIme { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
