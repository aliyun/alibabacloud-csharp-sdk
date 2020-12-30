// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListTransferableSkillGroupsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("SkillGroups")]
        [Validation(Required=false)]
        public List<ListTransferableSkillGroupsResponseBodySkillGroups> SkillGroups { get; set; }
        public class ListTransferableSkillGroupsResponseBodySkillGroups : TeaModel {
            [NameInMap("AllowPrivateOutboundNumber")]
            [Validation(Required=false)]
            public bool? AllowPrivateOutboundNumber { get; set; }

            [NameInMap("RoutingStrategy")]
            [Validation(Required=false)]
            public string RoutingStrategy { get; set; }

            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }

            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }

            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

            [NameInMap("AccQueueName")]
            [Validation(Required=false)]
            public string AccQueueName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SkillGroupDescription")]
            [Validation(Required=false)]
            public string SkillGroupDescription { get; set; }

            [NameInMap("AccSkillGroupName")]
            [Validation(Required=false)]
            public string AccSkillGroupName { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
