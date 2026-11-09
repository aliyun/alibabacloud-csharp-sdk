// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class BatchQuerySessionByClientIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of client statuses.</para>
        /// </summary>
        [NameInMap("OnlineStatusList")]
        [Validation(Required=false)]
        public List<BatchQuerySessionByClientIdsResponseBodyOnlineStatusList> OnlineStatusList { get; set; }
        public class BatchQuerySessionByClientIdsResponseBodyOnlineStatusList : TeaModel {
            /// <summary>
            /// <para>The client ID of the client. For more information about client IDs, see <a href="https://help.aliyun.com/document_detail/42420.html">Glossary</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_test@0001</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>Indicates whether the device is online. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Online.</description></item>
            /// <item><description><b>false</b>: Offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID. It is unique for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63309FDB-ED6C-46AE-B31C-A172FBA0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
