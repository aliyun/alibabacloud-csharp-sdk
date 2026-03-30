// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class BindMFADeviceRequest : TeaModel {
        /// <summary>
        /// <para>The first verification code.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/186179.html">CreateVirtualMFADevice</a> operation to create an MFA device and generate a key (value of <c>Base32StringSeed</c>). Then, use the key on the Alibaba Cloud app to manually add an MFA device, and obtain the two consecutive verification codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AuthenticationCode1")]
        [Validation(Required=false)]
        public string AuthenticationCode1 { get; set; }

        /// <summary>
        /// <para>The second verification code.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/186179.html">CreateVirtualMFADevice</a> operation to create an MFA device and generate a key (value of <c>Base32StringSeed</c>). Then, use the key on the Alibaba Cloud app to manually add an MFA device, and obtain the two consecutive verification codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>654321</para>
        /// </summary>
        [NameInMap("AuthenticationCode2")]
        [Validation(Required=false)]
        public string AuthenticationCode2 { get; set; }

        /// <summary>
        /// <para>The serial number of the MFA device.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/186179.html">CreateVirtualMFADevice</a> operation to obtain the serial number of the MFA device.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::177242285274****:mfa/device001</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
