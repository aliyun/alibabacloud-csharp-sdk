// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AuthorizationResourceInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>api-cujbijem1hkr4voden8g</para>
        /// </summary>
        [NameInMap("parentResourceId")]
        [Validation(Required=false)]
        public string ParentResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hr-d0mnu16m1hkgujnkgrcg</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
