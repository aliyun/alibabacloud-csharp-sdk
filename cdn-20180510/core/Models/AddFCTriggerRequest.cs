// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class AddFCTriggerRequest : TeaModel {
        /// <summary>
        /// The name of the event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventMetaName")]
        [Validation(Required=false)]
        public string EventMetaName { get; set; }

        /// <summary>
        /// The version of the event.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventMetaVersion")]
        [Validation(Required=false)]
        public string EventMetaVersion { get; set; }

        /// <summary>
        /// The feature trigger.
        /// </summary>
        [NameInMap("FunctionARN")]
        [Validation(Required=false)]
        public string FunctionARN { get; set; }

        /// <summary>
        /// The remarks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// The assigned Resource Access Management (RAM) role.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// The resources and filters for event listening.
        /// 
        /// This parameter is required.
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
