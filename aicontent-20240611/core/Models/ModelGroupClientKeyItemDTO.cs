// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelGroupClientKeyItemDTO : TeaModel {
        /// <summary>
        /// <para>The numeric ID of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The masked preview of the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-ab****yz</para>
        /// </summary>
        [NameInMap("keyPreview")]
        [Validation(Required=false)]
        public string KeyPreview { get; set; }

        /// <summary>
        /// <para>The authorization name (derived from the API key name).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default key</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
