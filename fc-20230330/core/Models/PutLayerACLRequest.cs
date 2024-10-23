// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutLayerACLRequest : TeaModel {
        /// <summary>
        /// <para>Specify the access permission of the layer. A value of 1 indicates public and a value of 0 indicates private. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specify whether the layer is a public layer. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("public")]
        [Validation(Required=false)]
        [Obsolete]
        public string Public { get; set; }

    }

}
