// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateApiStageVariableRequest : TeaModel {
        /// <summary>
        /// The ID of the runtime environment.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The name of the variable to be added. This parameter is case-sensitive.
        /// </summary>
        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("StageRouteModel")]
        [Validation(Required=false)]
        public string StageRouteModel { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [NameInMap("SupportRoute")]
        [Validation(Required=false)]
        public bool? SupportRoute { get; set; }

        /// <summary>
        /// Specifies whether routing is supported.
        /// </summary>
        [NameInMap("VariableName")]
        [Validation(Required=false)]
        public string VariableName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("VariableValue")]
        [Validation(Required=false)]
        public string VariableValue { get; set; }

    }

}
