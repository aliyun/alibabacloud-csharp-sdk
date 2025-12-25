// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAlarmBannerResponseBody : TeaModel {
        [NameInMap("BannerStatus")]
        [Validation(Required=false)]
        public DescribeAlarmBannerResponseBodyBannerStatus BannerStatus { get; set; }
        public class DescribeAlarmBannerResponseBodyBannerStatus : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4count</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9008</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sandbox</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5555DC36-0CF2-5AA3-B1C7-D6BD8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
