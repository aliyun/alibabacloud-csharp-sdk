// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelBatchGetHotelDetailShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The distributor account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>The language (such as en or zh).</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The list of standard hotel IDs. A maximum of 100 IDs are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;H001&quot;,&quot;H002&quot;]</para>
        /// </summary>
        [NameInMap("StandardHotelIds")]
        [Validation(Required=false)]
        public string StandardHotelIdsShrink { get; set; }

        /// <summary>
        /// <para>string</para>
        /// 
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
