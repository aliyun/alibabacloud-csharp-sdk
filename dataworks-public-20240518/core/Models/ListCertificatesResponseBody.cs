// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCertificatesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListCertificatesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListCertificatesResponseBodyPagingInfo : TeaModel {
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListCertificatesResponseBodyPagingInfoCertificates> Certificates { get; set; }
            public class ListCertificatesResponseBodyPagingInfoCertificates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1730217600000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1107550004253538</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>This is a file</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("FileSizeInBytes")]
                [Validation(Required=false)]
                public long? FileSizeInBytes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>676303114031776</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ca1.crt</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecb967ec-c137-48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
