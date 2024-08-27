// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteApiStageVariableRequest : TeaModel {
        /// <summary>
        /// The ID of the API group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        /// <summary>
        /// The name of the variable to be deleted. This parameter is case-sensitive.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VariableName")]
        [Validation(Required=false)]
        public string VariableName { get; set; }

    }

}
