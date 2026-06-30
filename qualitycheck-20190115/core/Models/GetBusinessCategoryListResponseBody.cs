// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetBusinessCategoryListResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. The value <b>200</b> indicates success. Any other value indicates failure, and the caller can determine the cause of failure based on this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBusinessCategoryListResponseBodyData Data { get; set; }
        public class GetBusinessCategoryListResponseBodyData : TeaModel {
            [NameInMap("BusinessCategoryBasicInfo")]
            [Validation(Required=false)]
            public List<GetBusinessCategoryListResponseBodyDataBusinessCategoryBasicInfo> BusinessCategoryBasicInfo { get; set; }
            public class GetBusinessCategoryListResponseBodyDataBusinessCategoryBasicInfo : TeaModel {
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public int? Bid { get; set; }

                [NameInMap("BusinessName")]
                [Validation(Required=false)]
                public string BusinessName { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

            }

        }

        /// <summary>
        /// <para>When an error occurs, this field provides error details; when successful, the value is <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A186A419-FDBE-464C-AED4-7121CAC73BF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. The caller can use this field to determine the request outcome:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> indicates success</description></item>
        /// <item><description><b>false/null</b> indicates failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
