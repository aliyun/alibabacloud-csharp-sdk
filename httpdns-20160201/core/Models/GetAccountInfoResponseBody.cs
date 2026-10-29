// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The current account information.</para>
        /// </summary>
        [NameInMap("AccountInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfo AccountInfo { get; set; }
        public class GetAccountInfoResponseBodyAccountInfo : TeaModel {
            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1337****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether the DNS over HTTPS (DoH) feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DohEnabled")]
            [Validation(Required=false)]
            public bool? DohEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether DoH is used to resolve all domain names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DohResolveAllEnabled")]
            [Validation(Required=false)]
            public bool? DohResolveAllEnabled { get; set; }

            /// <summary>
            /// <para>The number of DoH resolutions for the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MonthDohResolveCount")]
            [Validation(Required=false)]
            public long? MonthDohResolveCount { get; set; }

            /// <summary>
            /// <para>The monthly free resolution quota. This is the number of times you can call the HTTPDNS service for domain name resolution free of charge each calendar month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500000</para>
            /// </summary>
            [NameInMap("MonthFreeCount")]
            [Validation(Required=false)]
            public int? MonthFreeCount { get; set; }

            /// <summary>
            /// <para>The number of HTTP AES-encrypted resolutions for the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MonthHttpAesResolveCount")]
            [Validation(Required=false)]
            public long? MonthHttpAesResolveCount { get; set; }

            /// <summary>
            /// <para>The number of HTTPS AES-encrypted resolutions for the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MonthHttpsAesResolveCount")]
            [Validation(Required=false)]
            public long? MonthHttpsAesResolveCount { get; set; }

            /// <summary>
            /// <para>The total number of HTTPS resolutions for the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MonthHttpsResolveCount")]
            [Validation(Required=false)]
            public int? MonthHttpsResolveCount { get; set; }

            /// <summary>
            /// <para>The total number of HTTP resolutions for the current month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9927326</para>
            /// </summary>
            [NameInMap("MonthResolveCount")]
            [Validation(Required=false)]
            public int? MonthResolveCount { get; set; }

            /// <summary>
            /// <para>The number of resource plans. This is a legacy field and is always set to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PackageCount")]
            [Validation(Required=false)]
            public int? PackageCount { get; set; }

            /// <summary>
            /// <para>The signing secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50F9C40E****</para>
            /// </summary>
            [NameInMap("SignSecret")]
            [Validation(Required=false)]
            public string SignSecret { get; set; }

            /// <summary>
            /// <para>The number of requests to authenticated API operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>611523</para>
            /// </summary>
            [NameInMap("SignedCount")]
            [Validation(Required=false)]
            public long? SignedCount { get; set; }

            /// <summary>
            /// <para>The number of requests to unauthenticated API operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1523</para>
            /// </summary>
            [NameInMap("UnsignedCount")]
            [Validation(Required=false)]
            public long? UnsignedCount { get; set; }

            /// <summary>
            /// <para>Indicates whether unauthenticated API operations are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UnsignedEnabled")]
            [Validation(Required=false)]
            public bool? UnsignedEnabled { get; set; }

            /// <summary>
            /// <para>The HTTPDNS account status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The account is normal.</description></item>
            /// <item><description>2: The account has an overdue payment.</description></item>
            /// <item><description>3: The account is suspended.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public int? UserStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
