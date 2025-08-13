// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSampleListResponseBody : TeaModel {
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
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, with a default value of 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSampleListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSampleListResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>497</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Sample tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm0102</para>
            /// </summary>
            [NameInMap("sampleTags")]
            [Validation(Required=false)]
            public string SampleTags { get; set; }

            /// <summary>
            /// <para>Sample type</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHONE</para>
            /// </summary>
            [NameInMap("sampleType")]
            [Validation(Required=false)]
            public int? SampleType { get; set; }

            /// <summary>
            /// <para>Sample value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1770000000</para>
            /// </summary>
            [NameInMap("sampleValue")]
            [Validation(Required=false)]
            public string SampleValue { get; set; }

            /// <summary>
            /// <para>Update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699450018265</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>Version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        /// <summary>
        /// <para>Total pages</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
