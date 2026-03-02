// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class MetadataInfo : TeaModel {
        /// <summary>
        /// <para>The metadata field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Specifies whether the metadata is read only.</para>
        /// </summary>
        [NameInMap("virtual")]
        [Validation(Required=false)]
        public bool? Virtual { get; set; }

    }

}
