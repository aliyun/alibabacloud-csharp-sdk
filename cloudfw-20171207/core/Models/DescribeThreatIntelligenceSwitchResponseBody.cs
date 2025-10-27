// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeThreatIntelligenceSwitchResponseBody : TeaModel {
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<DescribeThreatIntelligenceSwitchResponseBodyCategoryList> CategoryList { get; set; }
        public class DescribeThreatIntelligenceSwitchResponseBodyCategoryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("CategoryDescribe")]
            [Validation(Required=false)]
            public string CategoryDescribe { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3000037</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CategoryParentId")]
            [Validation(Required=false)]
            public string CategoryParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public long? EnableStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6B8E0379-2629-59A1-B811-96F3E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
