// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class APIKeyAuthParameter : TeaModel {
        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>header</para>
        /// </summary>
        [NameInMap("in")]
        [Validation(Required=false)]
        public string In { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Authorization</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mock_value</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
