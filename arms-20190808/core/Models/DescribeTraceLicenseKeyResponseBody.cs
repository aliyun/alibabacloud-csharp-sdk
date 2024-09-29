// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeTraceLicenseKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The license key for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b590lhguqs@3a75d95f218****</para>
        /// </summary>
        [NameInMap("LicenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29053944-6FE5-4240-8927-10095ECE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
