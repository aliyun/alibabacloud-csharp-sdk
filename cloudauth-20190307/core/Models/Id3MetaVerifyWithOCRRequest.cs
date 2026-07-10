// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyWithOCRRequest : TeaModel {
        /// <summary>
        /// <para>The input stream of the portrait side image of the ID card. Specify either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("CertFile")]
        [Validation(Required=false)]
        public string CertFile { get; set; }

        /// <summary>
        /// <para>The image of the national emblem side of the ID card. Specify either CertNationalUrl or CertNationalFile, or leave both empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("CertNationalFile")]
        [Validation(Required=false)]
        public string CertNationalFile { get; set; }

        /// <summary>
        /// <para>The URL of the national emblem side image of the ID card. Specify a publicly accessible HTTP or HTTPS URL. Specify either CertNationalUrl or CertNationalFile, or leave both empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertNationalUrl")]
        [Validation(Required=false)]
        public string CertNationalUrl { get; set; }

        /// <summary>
        /// <para>The image of the portrait side of the ID card. Specify a publicly accessible HTTP or HTTPS URL. Specify either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertUrl")]
        [Validation(Required=false)]
        public string CertUrl { get; set; }

    }

}
