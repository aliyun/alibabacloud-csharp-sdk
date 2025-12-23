// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3B7E42BD-1D63-2F6B-C8E0-41BACEA76EEB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyResult> Result { get; set; }
        public class DescribeRegionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The console URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://opensearch-cn-hangzhou.console.aliyun.com">https://opensearch-cn-hangzhou.console.aliyun.com</a></para>
            /// </summary>
            [NameInMap("consoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }

            /// <summary>
            /// <para>The endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>opensearch.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
