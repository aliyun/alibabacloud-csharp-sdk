// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteFaceRecordV2Request : TeaModel {
        /// <summary>
        /// <para>The face group code. If this parameter is not specified, the face data of the user is deleted from all face groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgl****7uc</para>
        /// </summary>
        [NameInMap("FaceGroupCode")]
        [Validation(Required=false)]
        public string FaceGroupCode { get; set; }

        /// <summary>
        /// <para>The unique user identifier, which must be consistent with the one used when calling AddFaceRecord. If this parameter was not specified during registration, you can use the default image name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231****</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

    }

}
