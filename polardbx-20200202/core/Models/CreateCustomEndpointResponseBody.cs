// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateCustomEndpointResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCustomEndpointResponseBodyData Data { get; set; }
        public class CreateCustomEndpointResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pxe-c4gkgqg****7sgyg</para>
            /// </summary>
            [NameInMap("CustomEndpointId")]
            [Validation(Required=false)]
            public string CustomEndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-*********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DFF784E-DC31-5BBC-9B25-9261CD9E0AA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
