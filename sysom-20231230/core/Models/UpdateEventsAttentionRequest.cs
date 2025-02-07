// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateEventsAttentionRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateEventsAttentionRequestBody Body { get; set; }
        public class UpdateEventsAttentionRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("range")]
            [Validation(Required=false)]
            public string Range { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03de78af-f49f-433d-b5b1-0f6a70c493ba</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
