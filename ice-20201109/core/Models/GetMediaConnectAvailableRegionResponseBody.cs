// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectAvailableRegionResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectAvailableRegionResponseBodyContent Content { get; set; }
        public class GetMediaConnectAvailableRegionResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DefaultRegion")]
            [Validation(Required=false)]
            public string DefaultRegion { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<string> RegionList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>41CB9D4C-4650-5723-BA89-D6824F706ACB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
