// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class EnableProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f0d6d578-a305-40ac-ba1e-0a09f64cbc69</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
