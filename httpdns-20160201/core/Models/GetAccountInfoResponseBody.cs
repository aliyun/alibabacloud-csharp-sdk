// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        [NameInMap("AccountInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfo AccountInfo { get; set; }
        public class GetAccountInfoResponseBodyAccountInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1337****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("DohEnabled")]
            [Validation(Required=false)]
            public bool? DohEnabled { get; set; }

            [NameInMap("DohResolveAllEnabled")]
            [Validation(Required=false)]
            public bool? DohResolveAllEnabled { get; set; }

            [NameInMap("MonthDohResolveCount")]
            [Validation(Required=false)]
            public long? MonthDohResolveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1500000</para>
            /// </summary>
            [NameInMap("MonthFreeCount")]
            [Validation(Required=false)]
            public int? MonthFreeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MonthHttpsResolveCount")]
            [Validation(Required=false)]
            public int? MonthHttpsResolveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9927326</para>
            /// </summary>
            [NameInMap("MonthResolveCount")]
            [Validation(Required=false)]
            public int? MonthResolveCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PackageCount")]
            [Validation(Required=false)]
            public int? PackageCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50F9C40E****</para>
            /// </summary>
            [NameInMap("SignSecret")]
            [Validation(Required=false)]
            public string SignSecret { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>611523</para>
            /// </summary>
            [NameInMap("SignedCount")]
            [Validation(Required=false)]
            public long? SignedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1523</para>
            /// </summary>
            [NameInMap("UnsignedCount")]
            [Validation(Required=false)]
            public long? UnsignedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UnsignedEnabled")]
            [Validation(Required=false)]
            public bool? UnsignedEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public int? UserStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
