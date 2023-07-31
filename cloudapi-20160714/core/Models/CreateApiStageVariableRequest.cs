// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateApiStageVariableRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("StageRouteModel")]
        [Validation(Required=false)]
        [Obsolete]
        public string StageRouteModel { get; set; }

        [NameInMap("SupportRoute")]
        [Validation(Required=false)]
        public bool? SupportRoute { get; set; }

        [NameInMap("VariableName")]
        [Validation(Required=false)]
        public string VariableName { get; set; }

        [NameInMap("VariableValue")]
        [Validation(Required=false)]
        public string VariableValue { get; set; }

    }

}
