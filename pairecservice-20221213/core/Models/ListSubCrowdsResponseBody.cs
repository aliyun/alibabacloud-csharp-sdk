// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListSubCrowdsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5AEB79E-FAA4-5DCE-8CD7-1CAF549ECC3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCrowds")]
        [Validation(Required=false)]
        public List<ListSubCrowdsResponseBodySubCrowds> SubCrowds { get; set; }
        public class ListSubCrowdsResponseBodySubCrowds : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ManualInput</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SubCrowdId")]
            [Validation(Required=false)]
            public string SubCrowdId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1,user2</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public string Users { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
