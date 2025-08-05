// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPoliciesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>api-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-cq2fm65lhtgm9nrrl7ag</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withAttachments")]
        [Validation(Required=false)]
        public bool? WithAttachments { get; set; }

        [NameInMap("withSystemPolicy")]
        [Validation(Required=false)]
        public bool? WithSystemPolicy { get; set; }

    }

}
