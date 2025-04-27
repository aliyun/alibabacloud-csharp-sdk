// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePublicNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A88ECA1-D827-4581-AD39-05149586****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdatePublicNetworkResponseBodyResult Result { get; set; }
        public class UpdatePublicNetworkResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The status of the public network access switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

        }

    }

}
