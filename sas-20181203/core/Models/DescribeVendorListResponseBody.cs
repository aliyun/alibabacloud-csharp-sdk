// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVendorListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request, which can be used for troubleshooting and diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340D7FC4-D575-1661-8ACD-CFA7BE57B795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of vendors.</para>
        /// </summary>
        [NameInMap("VendorNameList")]
        [Validation(Required=false)]
        public List<string> VendorNameList { get; set; }

    }

}
