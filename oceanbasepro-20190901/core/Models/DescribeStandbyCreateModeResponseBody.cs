// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeStandbyCreateModeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeStandbyCreateModeResponseBodyData Data { get; set; }
        public class DescribeStandbyCreateModeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>BACKUP_RESTORE</para>
            /// </summary>
            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
