// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id3MetaVerifyWithOCRRequest : TeaModel {
        /// <summary>
        /// <para>Input stream for the portrait side of the ID card image. Choose either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("CertFile")]
        [Validation(Required=false)]
        public string CertFile { get; set; }

        /// <summary>
        /// <para>URL for the national emblem side of the ID card image. Choose either CertNationalUrl or CertNationalFile, or omit both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("CertNationalFile")]
        [Validation(Required=false)]
        public string CertNationalFile { get; set; }

        /// <summary>
        /// <para>National emblem side of the ID card image URL. A publicly accessible HTTP or HTTPS link. You can choose either CertNationalUrl or CertNationalFile, or omit both.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertNationalUrl")]
        [Validation(Required=false)]
        public string CertNationalUrl { get; set; }

        /// <summary>
        /// <para>Portrait side of the ID card image. A publicly accessible HTTP or HTTPS link. Choose either CertUrl or CertFile.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertUrl")]
        [Validation(Required=false)]
        public string CertUrl { get; set; }

    }

}
