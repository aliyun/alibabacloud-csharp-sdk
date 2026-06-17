// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeThreatIntelligenceSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of threat intelligence categories.</para>
        /// </summary>
        [NameInMap("CategoryList")]
        [Validation(Required=false)]
        public List<DescribeThreatIntelligenceSwitchResponseBodyCategoryList> CategoryList { get; set; }
        public class DescribeThreatIntelligenceSwitchResponseBodyCategoryList : TeaModel {
            /// <summary>
            /// <para>The action of the rule. Valid values:</para>
            /// <para><b>alert</b>: Monitor.</para>
            /// <para><b>drop</b>: Block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alert</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The description of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tor Export Malicious IP</para>
            /// </summary>
            [NameInMap("CategoryDescribe")]
            [Validation(Required=false)]
            public string CategoryDescribe { get; set; }

            /// <summary>
            /// <para>The ID of the threat intelligence category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000037</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tor Export Malicious IP</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The ID of the parent threat intelligence category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CategoryParentId")]
            [Validation(Required=false)]
            public string CategoryParentId { get; set; }

            /// <summary>
            /// <para>The status of the switch. Valid values:</para>
            /// <para><b>1</b>: enabled.</para>
            /// <para><b>0</b>: disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public long? EnableStatus { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B8E0379-2629-59A1-B811-96F3E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
