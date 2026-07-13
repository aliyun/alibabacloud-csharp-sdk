// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeProductDataRedundancyTypeStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProductDataRedundancyTypeStatResponseBodyData Data { get; set; }
        public class DescribeProductDataRedundancyTypeStatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of records returned by the request.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeProductDataRedundancyTypeStatResponseBodyDataContent> Content { get; set; }
            public class DescribeProductDataRedundancyTypeStatResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The data redundancy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LRS</para>
                /// </summary>
                [NameInMap("DataRedundancyType")]
                [Validation(Required=false)]
                public string DataRedundancyType { get; set; }

                /// <summary>
                /// <para>The resource count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                /// <summary>
                /// <para>The storage class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5748C531-80B1-5C31-8421-63A1830B9E48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
