// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListRepoTagResponseBodyImages> Images { get; set; }
        public class ListRepoTagResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The digest of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>67bfbcc12b67936ec7f867927817cbb071832b873dbcaed312a1930ba5f1****</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572839125000</para>
            /// </summary>
            [NameInMap("ImageCreate")]
            [Validation(Required=false)]
            public string ImageCreate { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45023655bf39c382e26a8607d057c27871dee163c1ecf48cc1ebf2a1****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The size of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27107966</para>
            /// </summary>
            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public long? ImageSize { get; set; }

            /// <summary>
            /// <para>The time when the image was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1572875608000</para>
            /// </summary>
            [NameInMap("ImageUpdate")]
            [Validation(Required=false)]
            public string ImageUpdate { get; set; }

            /// <summary>
            /// <para>The status of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>031572FA-7D8F-4C05-B790-1071E0E05DE6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
