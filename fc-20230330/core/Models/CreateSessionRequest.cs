// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateSessionRequest : TeaModel {
        /// <summary>
        /// <para>Creates session configurations.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateSessionInput Body { get; set; }

        /// <summary>
        /// <para>Specifies the version or alias to which the sesion belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
