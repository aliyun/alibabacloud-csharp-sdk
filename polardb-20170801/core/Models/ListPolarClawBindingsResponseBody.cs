// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ListPolarClawBindingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Bindings")]
        [Validation(Required=false)]
        public List<ListPolarClawBindingsResponseBodyBindings> Bindings { get; set; }
        public class ListPolarClawBindingsResponseBodyBindings : TeaModel {
            /// <summary>
            /// <para>Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>Channel ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>Account ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ChannelAccountId")]
            [Validation(Required=false)]
            public string ChannelAccountId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F2007D3-7E74-4ECB-89A8-BF130D******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
