// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeUsedServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Record details</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<DescribeUsedServiceResponseBodyRecords> Records { get; set; }
        public class DescribeUsedServiceResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>English name</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_abuse</para>
            /// </summary>
            [NameInMap("enName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>Service name</para>
            /// 
            /// <b>Example:</b>
            /// <para>注册风险识别服务</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Service code</para>
            /// 
            /// <b>Example:</b>
            /// <para>account_abuse</para>
            /// </summary>
            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

        }

    }

}
