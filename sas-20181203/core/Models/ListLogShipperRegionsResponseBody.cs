// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListLogShipperRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The regions supported by the log delivery feature.</para>
        /// </summary>
        [NameInMap("LogShipperRegionList")]
        [Validation(Required=false)]
        public List<ListLogShipperRegionsResponseBodyLogShipperRegionList> LogShipperRegionList { get; set; }
        public class ListLogShipperRegionsResponseBodyLogShipperRegionList : TeaModel {
            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9C4DE22-D242-5ABA-87EC-325ECBDC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
