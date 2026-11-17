// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteFaceRecordV2Request : TeaModel {
        /// <summary>
        /// <para>The code of the face group. If you do not specify this parameter, the face data of the user in all face groups is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgl****7uc</para>
        /// </summary>
        [NameInMap("FaceGroupCode")]
        [Validation(Required=false)]
        public string FaceGroupCode { get; set; }

        /// <summary>
        /// <para>The unique identifier of the user. This value must be the same as the one specified when the face record was added by using AddFaceRecord. If no user identifier was specified when the record was added, you can use the default image name.</para>
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
