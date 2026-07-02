// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeyVersionsResponseBody : TeaModel {
        [NameInMap("KeyVersions")]
        [Validation(Required=false)]
        public ListKeyVersionsResponseBodyKeyVersions KeyVersions { get; set; }
        public class ListKeyVersionsResponseBodyKeyVersions : TeaModel {
            [NameInMap("KeyVersion")]
            [Validation(Required=false)]
            public List<ListKeyVersionsResponseBodyKeyVersionsKeyVersion> KeyVersion { get; set; }
            public class ListKeyVersionsResponseBodyKeyVersionsKeyVersion : TeaModel {
                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                [NameInMap("KeyVersionId")]
                [Validation(Required=false)]
                public string KeyVersionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f71204c4-53cd-4eea-b405-653ba2db7e86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned key versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
