// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class UpdateSkillGroupRequest : TeaModel {
        /// <summary>
        /// 渠道类型
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public long? ChannelType { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public long? SkillGroupId { get; set; }

        [NameInMap("SkillGroupName")]
        [Validation(Required=false)]
        public string SkillGroupName { get; set; }

    }

}
