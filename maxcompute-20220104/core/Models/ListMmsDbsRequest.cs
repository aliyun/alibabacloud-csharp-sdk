// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsDbsRequest : TeaModel {
        /// <summary>
        /// <para>Data source name</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of records per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sorting conditions</para>
        /// </summary>
        [NameInMap("sorter")]
        [Validation(Required=false)]
        public ListMmsDbsRequestSorter Sorter { get; set; }
        public class ListMmsDbsRequestSorter : TeaModel {
            /// <summary>
            /// <para>Number of data rows in the database</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("numRows")]
            [Validation(Required=false)]
            public string NumRows { get; set; }

            /// <summary>
            /// <para>Size of data in the database</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:17</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Data source status</para>
        /// 
        /// <b>Example:</b>
        /// <para>STARTED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
