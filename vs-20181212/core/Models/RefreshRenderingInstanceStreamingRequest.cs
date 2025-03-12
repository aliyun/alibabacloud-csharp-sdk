// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class RefreshRenderingInstanceStreamingRequest : TeaModel {
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public RefreshRenderingInstanceStreamingRequestClientInfo ClientInfo { get; set; }
        public class RefreshRenderingInstanceStreamingRequestClientInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>172.21.128.110</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NewClient")]
            [Validation(Required=false)]
            public bool? NewClient { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
