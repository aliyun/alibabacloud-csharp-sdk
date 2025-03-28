// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentDeploymentSpec : TeaModel {
        [NameInMap("baseline")]
        [Validation(Required=false)]
        public EnvironmentSnapshot Baseline { get; set; }

        [NameInMap("changes")]
        [Validation(Required=false)]
        public EnvironmentChanges Changes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("skipRemoveResources")]
        [Validation(Required=false)]
        public bool? SkipRemoveResources { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public EnvironmentStagedConfigs Target { get; set; }

        [NameInMap("webhookCodeContext")]
        [Validation(Required=false)]
        public WebhookCodeContext WebhookCodeContext { get; set; }

    }

}
