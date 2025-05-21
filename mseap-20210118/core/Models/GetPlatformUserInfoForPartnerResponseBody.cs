// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class GetPlatformUserInfoForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>djisdpfOjofjifojfajaspsdkasdada</para>
        /// </summary>
        [NameInMap("EncryptedOpenId")]
        [Validation(Required=false)]
        public string EncryptedOpenId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>djisdpfOjofjifojfajaspsdkasdada</para>
        /// </summary>
        [NameInMap("EncryptedUnionId")]
        [Validation(Required=false)]
        public string EncryptedUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11111111111111111111111</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0320C9F4-5EDC-5355-9D7E-DF4CF6C2B3BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>success</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
