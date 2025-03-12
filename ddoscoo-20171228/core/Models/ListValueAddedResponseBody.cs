// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListValueAddedResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ValueAddedList")]
        [Validation(Required=false)]
        public List<ListValueAddedResponseBodyValueAddedList> ValueAddedList { get; set; }
        public class ListValueAddedResponseBodyValueAddedList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1580918400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1575527305000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddos_fl_pre-cn-xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5497558138880</para>
            /// </summary>
            [NameInMap("LogSize")]
            [Validation(Required=false)]
            public long? LogSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StoreRegion")]
            [Validation(Required=false)]
            public string StoreRegion { get; set; }

        }

    }

}
