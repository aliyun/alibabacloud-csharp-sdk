// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateTriggerInput : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
