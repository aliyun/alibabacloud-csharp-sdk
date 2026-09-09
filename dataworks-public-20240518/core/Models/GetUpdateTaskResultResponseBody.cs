// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetUpdateTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF020E7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The node update result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUpdateTaskResultResponseBodyResult Result { get; set; }
        public class GetUpdateTaskResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The failure message. This field is returned if the update fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid Param xxx</para>
            /// </summary>
            [NameInMap("FailureMessage")]
            [Validation(Required=false)]
            public string FailureMessage { get; set; }

            /// <summary>
            /// <para>The update status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Updating: The node is being updated.</description></item>
            /// <item><description>Updated: The node is updated.</description></item>
            /// <item><description>UpdateFailed: The node failed to be updated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Updated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
