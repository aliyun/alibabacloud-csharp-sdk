// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdatePhoneMessageQrdlRequest : TeaModel {
        /// <summary>
        /// <para>SpaceId/instance ID of ISV sub customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9383884</para>
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
        /// <para>Number, enter the country/region code+number.</para>
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

        /// <summary>
        /// <para>QR code encoding.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29338838</para>
        /// </summary>
        [NameInMap("QrdlCode")]
        [Validation(Required=false)]
        public string QrdlCode { get; set; }

    }

}
