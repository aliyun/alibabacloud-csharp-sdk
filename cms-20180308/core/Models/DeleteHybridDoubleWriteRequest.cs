// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DeleteHybridDoubleWriteRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-source</para>
        /// </summary>
        [NameInMap("SourceNamespace")]
        [Validation(Required=false)]
        public string SourceNamespace { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12706766********</para>
        /// </summary>
        [NameInMap("SourceUserId")]
        [Validation(Required=false)]
        public long? SourceUserId { get; set; }

    }

}
