// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleAgentInfoAttributeShowInfoMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FIRST_BAGGAGE</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
