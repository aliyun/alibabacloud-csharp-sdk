// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Credential : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
