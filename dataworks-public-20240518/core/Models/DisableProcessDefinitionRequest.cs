// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DisableProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11792</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
