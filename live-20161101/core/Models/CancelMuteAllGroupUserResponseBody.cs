// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CancelMuteAllGroupUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-****-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Actual return result of the service</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CancelMuteAllGroupUserResponseBodyResult Result { get; set; }
        public class CancelMuteAllGroupUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the cancellation was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Successful.</para>
            /// </description></item>
            /// <item><description><para>false: Unsuccessful.</para>
            /// </description></item>
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
