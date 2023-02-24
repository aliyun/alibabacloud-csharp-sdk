// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeyVersionsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of key versions.
        /// </summary>
        [NameInMap("KeyVersions")]
        [Validation(Required=false)]
        public ListKeyVersionsResponseBodyKeyVersions KeyVersions { get; set; }
        public class ListKeyVersionsResponseBodyKeyVersions : TeaModel {
            [NameInMap("KeyVersion")]
            [Validation(Required=false)]
            public List<ListKeyVersionsResponseBodyKeyVersionsKeyVersion> KeyVersion { get; set; }
            public class ListKeyVersionsResponseBodyKeyVersionsKeyVersion : TeaModel {
                /// <summary>
                /// The date and time when the CMK version was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

                /// <summary>
                /// The globally unique ID of the CMK.
                /// 
                /// >  If you set the KeyId parameter to the alias of the CMK, the ID of the CMK to which the alias is bound is returned.
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                /// <summary>
                /// The globally unique ID of the CMK version.
                /// </summary>
                [NameInMap("KeyVersionId")]
                [Validation(Required=false)]
                public string KeyVersionId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned key versions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
