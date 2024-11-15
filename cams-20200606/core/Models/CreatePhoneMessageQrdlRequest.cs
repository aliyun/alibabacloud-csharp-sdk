// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreatePhoneMessageQrdlRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>838833</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>Produce QR code image format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PNG</para>
        /// </summary>
        [NameInMap("GenerateQrImage")]
        [Validation(Required=false)]
        public string GenerateQrImage { get; set; }

        /// <summary>
        /// <para>The phone number. Add the country code before the phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861380000</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Message content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("PrefilledMessage")]
        [Validation(Required=false)]
        public string PrefilledMessage { get; set; }

    }

}
