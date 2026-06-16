// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The credential name (specified as a numeric code). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Codes starting with 03: enterprise qualification<list type="bullet">
        /// <item><description>0301: business license issued in the Chinese mainland</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Codes starting with 04: transaction voucher<list type="bullet">
        /// <item><description>0401: bank statement</description></item>
        /// <item><description>0402: payslip</description></item>
        /// <item><description>0403: utility bill</description></item>
        /// <item><description>0405: credit card statement</description></item>
        /// <item><description>0499: other.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0301</para>
        /// </summary>
        [NameInMap("CredName")]
        [Validation(Required=false)]
        public string CredName { get; set; }

        /// <summary>
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>03: enterprise qualification</description></item>
        /// <item><description>04: transaction voucher.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03</para>
        /// </summary>
        [NameInMap("CredType")]
        [Validation(Required=false)]
        public string CredType { get; set; }

        /// <summary>
        /// <para>The image input stream.</para>
        /// <remarks>
        /// <para>Specify either ImageUrl or ImageFile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("ImageFile")]
        [Validation(Required=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// <remarks>
        /// <para>Specify either ImageUrl or ImageFile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-bj01.avic.com/eavic-prod-commodity/pic/commodity/94677ee6-1067-4287-8ff4-6e030ef3a5a8.jpg">https://oss-bj01.avic.com/eavic-prod-commodity/pic/commodity/94677ee6-1067-4287-8ff4-6e030ef3a5a8.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The call mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ANTI_FAKE_CHECK: image quality and tampering detection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>取值：ANTI_FAKE_CHECK</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
