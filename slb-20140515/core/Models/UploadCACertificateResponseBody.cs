// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadCACertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139a0******-cn-east-hangzhou-01</para>
        /// </summary>
        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        /// <summary>
        /// <para>The CA certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycacert01</para>
        /// </summary>
        [NameInMap("CACertificateName")]
        [Validation(Required=false)]
        public string CACertificateName { get; set; }

        /// <summary>
        /// <para>The domain name on the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.example.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The time when the CA certificate was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-31T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp when the CA certificate was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1504147745000</para>
        /// </summary>
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// <para>The time when the CA certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-21T06:04:25Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The timestamp when the server certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732169065000</para>
        /// </summary>
        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public long? ExpireTimeStamp { get; set; }

        /// <summary>
        /// <para>The fingerprint of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:DF:AB:ED</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rt******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
