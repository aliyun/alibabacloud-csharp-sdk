// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyPhoneTagsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ServiceTag")]
        [Validation(Required=false)]
        public string ServiceTag { get; set; }

        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public List<string> SkillGroupIdList { get; set; }

    }

}
