// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Credential : TeaModel {
        /// <summary>
        /// <para>sts ak</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("accessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        /// <summary>
        /// <para>The OSS path.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public string Dir { get; set; }

        /// <summary>
        /// <para>The timeout period.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// <para>The OSS domain name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <para>The OSS access policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>sts token</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The OSS access signature.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
