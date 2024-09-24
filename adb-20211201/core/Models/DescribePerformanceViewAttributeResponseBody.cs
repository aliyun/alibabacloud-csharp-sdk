// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePerformanceViewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-bp198m028ih55xxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FillOriginViewKeys")]
        [Validation(Required=false)]
        public bool? FillOriginViewKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E031AABF-BD56-5966-A063-4283EF18DB45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public DescribePerformanceViewAttributeResponseBodyViewDetail ViewDetail { get; set; }
        public class DescribePerformanceViewAttributeResponseBodyViewDetail : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategories> Categories { get; set; }
            public class DescribePerformanceViewAttributeResponseBodyViewDetailCategories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys> Keys { get; set; }
                public class DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AnalyticDB_CPU</para>
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChartLinked")]
            [Validation(Required=false)]
            public bool? ChartLinked { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}
