// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// js sdk中自动生成的鉴权token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public List<long?> SkillGroupId { get; set; }

        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public List<long?> SkillGroupIdList { get; set; }

    }

}
