// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRuleStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatisticsInfos")]
        [Validation(Required=false)]
        public List<DescribeDefenseRuleStatisticsResponseBodyStatisticsInfos> StatisticsInfos { get; set; }
        public class DescribeDefenseRuleStatisticsResponseBodyStatisticsInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>action</para>
            /// </summary>
            [NameInMap("FourthValue")]
            [Validation(Required=false)]
            public string FourthValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sytem</para>
            /// </summary>
            [NameInMap("PrimaryValue")]
            [Validation(Required=false)]
            public string PrimaryValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("SecondaryValue")]
            [Validation(Required=false)]
            public string SecondaryValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ThirdValue")]
            [Validation(Required=false)]
            public string ThirdValue { get; set; }

        }

    }

}
