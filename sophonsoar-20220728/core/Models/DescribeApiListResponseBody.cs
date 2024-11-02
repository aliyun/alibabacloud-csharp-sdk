// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeApiListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the service.</para>
        /// </summary>
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<DescribeApiListResponseBodyApiList> ApiList { get; set; }
        public class DescribeApiListResponseBodyApiList : TeaModel {
            /// <summary>
            /// <para>The link to the API references of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxx">https://xxxxx</a></para>
            /// </summary>
            [NameInMap("DocUrl")]
            [Validation(Required=false)]
            public string DocUrl { get; set; }

            /// <summary>
            /// <para>The POP code of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sas</para>
            /// </summary>
            [NameInMap("PopCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud Security Center</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A15D31E-B38B-5F7F-8DC0-1C74408875AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
