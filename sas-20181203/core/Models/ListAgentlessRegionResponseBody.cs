// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAgentlessRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the regions.</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VendorRegionList")]
        [Validation(Required=false)]
        public List<ListAgentlessRegionResponseBodyVendorRegionList> VendorRegionList { get; set; }
        public class ListAgentlessRegionResponseBodyVendorRegionList : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

    }

}
