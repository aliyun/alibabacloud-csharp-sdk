// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAutoRenewAttributeResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAutoRenewAttributeResponseBodyItems Items { get; set; }
        public class DescribeAutoRenewAttributeResponseBodyItems : TeaModel {
            [NameInMap("AutoRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute> AutoRenewAttribute { get; set; }
            public class DescribeAutoRenewAttributeResponseBodyItemsAutoRenewAttribute : TeaModel {
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
