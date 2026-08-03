// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXT_ORDER_001</para>
        /// </summary>
        [NameInMap("ExternalOrderNo")]
        [Validation(Required=false)]
        public string ExternalOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SO202606290001</para>
        /// </summary>
        [NameInMap("OrderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TracerId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
