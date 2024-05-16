// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class UpdateFCTriggerRequest : TeaModel {
        /// <summary>
        /// The feature trigger.
        /// </summary>
        [NameInMap("FunctionARN")]
        [Validation(Required=false)]
        public string FunctionARN { get; set; }

        /// <summary>
        /// The remarks.
        /// </summary>
        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The assigned RAM role.
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// The resources and filters for event listening.
        /// </summary>
        [NameInMap("SourceARN")]
        [Validation(Required=false)]
        public string SourceARN { get; set; }

        /// <summary>
        /// The trigger that corresponds to the Function Compute service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TriggerARN")]
        [Validation(Required=false)]
        public string TriggerARN { get; set; }

    }

}
