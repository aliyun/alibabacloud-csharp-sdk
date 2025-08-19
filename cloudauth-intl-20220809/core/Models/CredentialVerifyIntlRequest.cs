// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>Credential name (numeric code):</para>
        /// <list type="bullet">
        /// <item><description>Starting with 03: Enterprise Qualification<list type="bullet">
        /// <item><description>0301: Mainland China Business License</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Starting with 04, Transaction Voucher<list type="bullet">
        /// <item><description>0401: Bank Statement</description></item>
        /// <item><description>0402: Pay Slip</description></item>
        /// <item><description>0403: Utility Bill</description></item>
        /// <item><description>0405: Credit Card Statement</description></item>
        /// <item><description>0499: Others</description></item>
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
        /// <para>Credential type:</para>
        /// <list type="bullet">
        /// <item><description>03: Enterprise Qualification</description></item>
        /// <item><description>04: Transaction Voucher</description></item>
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
        /// <para>Image input stream.</para>
        /// <remarks>
        /// <para>Choose either ImageUrl or ImageFile.</para>
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
        /// <para>Choose either ImageUrl or ImageFile.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-bj01.avic.com/eavic-prod-commodity/pic/commodity/94677ee6-1067-4287-8ff4-6e030ef3a5a8.jpg">https://oss-bj01.avic.com/eavic-prod-commodity/pic/commodity/94677ee6-1067-4287-8ff4-6e030ef3a5a8.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>Invocation mode:</para>
        /// <list type="bullet">
        /// <item><description>ANTI_FAKE_CHECK: Image quality and tampering detection.</description></item>
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
