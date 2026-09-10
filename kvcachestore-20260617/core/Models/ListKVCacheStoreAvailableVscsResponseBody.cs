// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kvcachestore20260617.Models
{
    public class ListKVCacheStoreAvailableVscsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id-xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of available VSC resources.</para>
        /// </summary>
        [NameInMap("Vscs")]
        [Validation(Required=false)]
        public List<ListKVCacheStoreAvailableVscsResponseBodyVscs> Vscs { get; set; }
        public class ListKVCacheStoreAvailableVscsResponseBodyVscs : TeaModel {
            /// <summary>
            /// <para>The ID of the VSC device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsc-xxxxx</para>
            /// </summary>
            [NameInMap("VscId")]
            [Validation(Required=false)]
            public string VscId { get; set; }

            /// <summary>
            /// <para>The current status of the VSC device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("VscStatus")]
            [Validation(Required=false)]
            public string VscStatus { get; set; }

        }

    }

}
