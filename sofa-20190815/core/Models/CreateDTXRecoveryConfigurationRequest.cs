// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDTXRecoveryConfigurationRequest : TeaModel {
        [NameInMap("ActionMode")]
        [Validation(Required=false)]
        public long? ActionMode { get; set; }

        [NameInMap("ActivityMode")]
        [Validation(Required=false)]
        public long? ActivityMode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OldBiztype")]
        [Validation(Required=false)]
        public string OldBiztype { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public long? Role { get; set; }

        [NameInMap("SplitRuleJsonStr")]
        [Validation(Required=false)]
        public string SplitRuleJsonStr { get; set; }

    }

}
