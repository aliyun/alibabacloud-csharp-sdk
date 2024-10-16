// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class RegisterCustomFaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the figure library in which you want to register a custom face. The ID is used to uniquely identify a figure library. You can specify the ID of a custom figure library. Make sure that the ID is unique and keep the ID for future API operation calls. If you set this parameter to the ID of a system figure library, the custom face is registered in the system figure library. The ID can be up to 120 characters in length and is not case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CategoryId001-****</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The URL of the facial image that you want to register for the specified figure. The image must contain only one face.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-****.jpeg">http://example-****.jpeg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the figure for which you want to register a custom face. The ID is used to uniquely identify a figure. You can specify a figure ID. Make sure that the ID is unique and keep the ID for future API operation calls. The ID can be up to 120 characters in length and is not case-sensitive. The value returned is of the String type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PersonId001-****</para>
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public string PersonId { get; set; }

        [NameInMap("PersonName")]
        [Validation(Required=false)]
        public string PersonName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
