// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateMessageGroupResponseBody : TeaModel {
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
        public UpdateMessageGroupResponseBodyResult Result { get; set; }
        public class UpdateMessageGroupResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the update was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The update was successful.</description></item>
            /// <item><description>false: The update failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
