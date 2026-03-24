// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeChargeResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing calculation results for each module.</para>
        /// </summary>
        [NameInMap("ModuleDetails")]
        [Validation(Required=false)]
        public List<DescribeChargeResultResponseBodyModuleDetails> ModuleDetails { get; set; }
        public class DescribeChargeResultResponseBodyModuleDetails : TeaModel {
            /// <summary>
            /// <para>The ID of the billing module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domainCount</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The number of SeCUs for the billing module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SeCu")]
            [Validation(Required=false)]
            public double? SeCu { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of calculated Security Capacity Units (SeCUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("TotalSeCu")]
        [Validation(Required=false)]
        public double? TotalSeCu { get; set; }

    }

}
