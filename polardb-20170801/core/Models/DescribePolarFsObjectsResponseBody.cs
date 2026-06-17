// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarFsObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The files and subdirectories in the specified path.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribePolarFsObjectsResponseBodyItems> Items { get; set; }
        public class DescribePolarFsObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The size of the item in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <para>The time when the item was created, as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T09:37:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The time the item was last modified, as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T09:37:10Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            /// <summary>
            /// <para>The target path of the symbolic link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("LinkTarget")]
            [Validation(Required=false)]
            public string LinkTarget { get; set; }

            /// <summary>
            /// <para>The file system permissions in octal format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>755</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The number of hard links to the item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Nlink")]
            [Validation(Required=false)]
            public int? Nlink { get; set; }

            /// <summary>
            /// <para>The owner of the file or directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The absolute path of the file or subdirectory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>directory</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The number of records returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records to return per page. Valid values: 30, 50, and 100. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The path that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The PolarFs instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i7*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
