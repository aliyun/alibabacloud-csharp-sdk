// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMessageGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateMessageGroupResponseBodyResult Result { get; set; }
        public class CreateMessageGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test001</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extension { get; set; }

            /// <summary>
            /// <para>The ID of the message group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AE35-****-T95F</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

    }

}
