// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelGroupClientKeyItemDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sk-ab****yz</para>
        /// </summary>
        [NameInMap("keyPreview")]
        [Validation(Required=false)]
        public string KeyPreview { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Default Key</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
