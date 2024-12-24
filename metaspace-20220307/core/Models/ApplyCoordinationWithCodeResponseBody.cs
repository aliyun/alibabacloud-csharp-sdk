// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Metaspace20220307.Models
{
    public class ApplyCoordinationWithCodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ApplyCoordinationWithCodeResponseBodyData Data { get; set; }
        public class ApplyCoordinationWithCodeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>co-0ad0f3p4n2******</para>
            /// </summary>
            [NameInMap("CoId")]
            [Validation(Required=false)]
            public string CoId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COORDINATING</para>
            /// </summary>
            [NameInMap("CoordinateStatus")]
            [Validation(Required=false)]
            public string CoordinateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DQpbRGVza3RvcF0NCkZvcmNlVGxzVHlwZT0xDQ******</para>
            /// </summary>
            [NameInMap("CoordinateTicket")]
            [Validation(Required=false)]
            public string CoordinateTicket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1126819517******</para>
            /// </summary>
            [NameInMap("CoordinatorAliUid")]
            [Validation(Required=false)]
            public long? CoordinatorAliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bob</para>
            /// </summary>
            [NameInMap("CoordinatorUserId")]
            [Validation(Required=false)]
            public string CoordinatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1126819517******</para>
            /// </summary>
            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public long? OwnerAliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-3vv4mf8zxg******</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo-desktop</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CloudDesktop</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
