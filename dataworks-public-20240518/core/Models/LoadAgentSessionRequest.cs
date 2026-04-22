// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LoadAgentSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4as3dasf654a</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public LoadAgentSessionRequestParams Params { get; set; }
        public class LoadAgentSessionRequestParams : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public LoadAgentSessionRequestParamsMeta Meta { get; set; }
            public class LoadAgentSessionRequestParamsMeta : TeaModel {
                [NameInMap("BeginLogOffset")]
                [Validation(Required=false)]
                public long? BeginLogOffset { get; set; }

                [NameInMap("IsReload")]
                [Validation(Required=false)]
                public bool? IsReload { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
