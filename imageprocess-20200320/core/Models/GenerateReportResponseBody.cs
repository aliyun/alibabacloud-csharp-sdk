// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class GenerateReportResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GenerateReportResponseBodyData> Data { get; set; }
        public class GenerateReportResponseBodyData : TeaModel {
            [NameInMap("ActionNames")]
            [Validation(Required=false)]
            public List<string> ActionNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PDF</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/cefe_295855287226852864_23eebf3799c7442a992d2e56fde87616">http://viapi-customer-pop.oss-cn-shanghai.aliyuncs.com/cefe_295855287226852864_23eebf3799c7442a992d2e56fde87616</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>imageUrl download failed</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>528B54D4-3AAB-47CF-B6CE-0C2A2FB4C7C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
