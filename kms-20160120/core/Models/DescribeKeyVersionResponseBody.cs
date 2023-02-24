// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyVersionResponseBody : TeaModel {
        /// <summary>
        /// The metadata of the CMK version.
        /// </summary>
        [NameInMap("KeyVersion")]
        [Validation(Required=false)]
        public DescribeKeyVersionResponseBodyKeyVersion KeyVersion { get; set; }
        public class DescribeKeyVersionResponseBodyKeyVersion : TeaModel {
            /// <summary>
            /// The date and time when the CMK version was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            /// <summary>
            /// The globally unique ID of the CMK.
            /// 
            /// >  If you set the KeyId parameter in the request to an alias of the CMK, the ID of the CMK to which the alias is bound is returned.
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

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
