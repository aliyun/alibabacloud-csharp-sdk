// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetExperimentsUsersStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F082BD0D-21E1-5F9B-81A0-AB07485B03CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<GetExperimentsUsersStatisticsResponseBodyUsers> Users { get; set; }
        public class GetExperimentsUsersStatisticsResponseBodyUsers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12345******67890</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
