// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D39EE0F1-D7EF-5F46-B781-6BF4185308B0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyResult Result { get; set; }
        public class CreateInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-2r42ppr7901</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
