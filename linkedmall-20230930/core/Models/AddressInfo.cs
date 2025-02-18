// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class AddressInfo : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>陕西省西安市新城区xxx大厦xx室</para>
        /// </summary>
        [NameInMap("addressDetail")]
        [Validation(Required=false)]
        public string AddressDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("addressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>610102</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任先生</para>
        /// </summary>
        [NameInMap("receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182***5674</para>
        /// </summary>
        [NameInMap("receiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>61010212</para>
        /// </summary>
        [NameInMap("townDivisionCode")]
        [Validation(Required=false)]
        public string TownDivisionCode { get; set; }

    }

}
