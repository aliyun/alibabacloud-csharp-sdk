// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetBusinessCategoryListResponseBody : TeaModel {
        /// <summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public int? Bid { get; set; }

                [NameInMap("BusinessName")]
                [Validation(Required=false)]
                public string BusinessName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A186A419-FDBE-464C-AED4-7121CAC73BF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
