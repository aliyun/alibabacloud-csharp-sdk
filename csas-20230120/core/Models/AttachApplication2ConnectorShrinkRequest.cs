// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AttachApplication2ConnectorShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public string ApplicationIdsShrink { get; set; }

        /// <summary>
        /// <para>ConnectorID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-94db94e06b98****</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

    }

}
