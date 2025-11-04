// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectAvailableRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The rsponse body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectAvailableRegionResponseBodyContent Content { get; set; }
        public class GetMediaConnectAvailableRegionResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The default region. You can ignore the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DefaultRegion")]
            [Validation(Required=false)]
            public string DefaultRegion { get; set; }

            /// <summary>
            /// <para>The supported regions.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<string> RegionList { get; set; }

        }

        /// <summary>
        /// <para>The call description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41CB9D4C-4650-5723-BA89-D6824F706ACB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned error code. A value of 0 indicates the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
