// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantEncryptionResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>job</para>
        /// </summary>
        [NameInMap("TenantEncryption")]
        [Validation(Required=false)]
        public ModifyTenantEncryptionResponseBodyTenantEncryption TenantEncryption { get; set; }
        public class ModifyTenantEncryptionResponseBodyTenantEncryption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>EncryptionKey</para>
            /// </summary>
            [NameInMap("EncryptionType")]
            [Validation(Required=false)]
            public string EncryptionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ob2mr3oae0****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
