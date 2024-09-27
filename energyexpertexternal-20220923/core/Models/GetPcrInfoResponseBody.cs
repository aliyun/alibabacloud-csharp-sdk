// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetPcrInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPcrInfoResponseBodyData Data { get; set; }
        public class GetPcrInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the report was created. The timestamp is in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1709109790532</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Report name</para>
            /// 
            /// <b>Example:</b>
            /// <para>report name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Download url link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://energy.alibabacloud.com">https://energy.alibabacloud.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A0AEC56-5C9A-5D47-93DF-7227836FFF82</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
