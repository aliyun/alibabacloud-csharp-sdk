// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyWuyingServerAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>yourPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ws-0bw2f11****dial</para>
        /// </summary>
        [NameInMap("WuyingServerId")]
        [Validation(Required=false)]
        public string WuyingServerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exampleServerName</para>
        /// </summary>
        [NameInMap("WuyingServerName")]
        [Validation(Required=false)]
        public string WuyingServerName { get; set; }

    }

}
