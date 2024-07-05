// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UnregisterCustomFaceRequest : TeaModel {
        /// <summary>
        /// The ID of the figure library. The ID is used to uniquely identify a figure library. You can specify the ID of a custom figure library. Make sure that the ID is unique. If you set this parameter to the ID of a system figure library, the system figure library is used. The ID can be up to 120 characters in length and is not case-sensitive. You can call the [ListCustomPersons](https://help.aliyun.com/document_detail/187787.html) operation to query the figure library ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The ID of the face. The ID is used to uniquely identify a face. Make sure that the ID is unique. The ID can be up to 120 characters in length and is not case-sensitive. You can call the [ListCustomPersons](https://help.aliyun.com/document_detail/187787.html) operation to query the face ID. If you set this parameter to ALL, all the faces associated with the specified figure are deleted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FaceId")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the figure. The ID is used to uniquely identify a custom figure. Make sure that the ID is unique. The ID can be up to 120 characters in length and is not case-sensitive. You can call the [ListCustomPersons](https://help.aliyun.com/document_detail/187787.html) operation to query the figure ID. If you set this parameter to ALL, all the faces in the specified figure library are deleted, and the custom figure library is deleted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
