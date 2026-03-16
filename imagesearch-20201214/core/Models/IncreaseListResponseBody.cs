// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class IncreaseListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the batch task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public IncreaseListResponseBodyData Data { get; set; }
        public class IncreaseListResponseBodyData : TeaModel {
            [NameInMap("Increments")]
            [Validation(Required=false)]
            public IncreaseListResponseBodyDataIncrements Increments { get; set; }
            public class IncreaseListResponseBodyDataIncrements : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<IncreaseListResponseBodyDataIncrementsInstance> Instance { get; set; }
                public class IncreaseListResponseBodyDataIncrementsInstance : TeaModel {
                    [NameInMap("BucketName")]
                    [Validation(Required=false)]
                    public string BucketName { get; set; }

                    [NameInMap("CallbackAddress")]
                    [Validation(Required=false)]
                    public string CallbackAddress { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ErrorUrl")]
                    [Validation(Required=false)]
                    public string ErrorUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public long? UtcModified { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the page to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
