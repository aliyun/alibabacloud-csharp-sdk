// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class AddressInfo : TeaModel {
        /// <summary>
        /// <para>The detailed shipping address. Enter the full address in the format of province, city, district/county, street, and community.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>陕西省西安市新城区xx街道xxx大厦xx室</para>
        /// </summary>
        [NameInMap("addressDetail")]
        [Validation(Required=false)]
        public string AddressDetail { get; set; }

        /// <summary>
        /// <para>The address ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("addressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        /// <summary>
        /// <para>The level-4 address code for the district or county. This parameter is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>The recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任先生</para>
        /// </summary>
        [NameInMap("receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// <para>The phone number of the recipient.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182***5674</para>
        /// </summary>
        [NameInMap("receiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// <para>The level-5 address code for the town or street. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106109</para>
        /// </summary>
        [NameInMap("townDivisionCode")]
        [Validation(Required=false)]
        public string TownDivisionCode { get; set; }

    }

}
