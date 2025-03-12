// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigLayer7CertRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public int? CertId { get; set; }

        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testCertName</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertRegion")]
        [Validation(Required=false)]
        public string CertRegion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
