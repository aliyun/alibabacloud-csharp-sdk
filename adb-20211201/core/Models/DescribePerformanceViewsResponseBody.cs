// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePerformanceViewsResponseBody : TeaModel {
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
        /// <para>3A8F6106-6AFD-5A34-9C80-8DE2C42D06E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Views")]
        [Validation(Required=false)]
        public List<DescribePerformanceViewsResponseBodyViews> Views { get; set; }
        public class DescribePerformanceViewsResponseBodyViews : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-18T07:06:53.000+00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-18T07:07:32.000+00:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("ViewName")]
            [Validation(Required=false)]
            public string ViewName { get; set; }

        }

    }

}
