// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class SubmitIntentionForPartnerRequest : TeaModel {
        [NameInMap("Area")]
        [Validation(Required=false)]
        public string Area { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>esp.isp</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lingjun</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("CommodityType")]
        [Validation(Required=false)]
        public string CommodityType { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ceshi</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;beianServiceNumber\&quot;:\&quot;9969c666-0935-4c5b-8042-926ff546e39f\&quot;}</para>
        /// </summary>
        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>country</para>
        /// </summary>
        [NameInMap("Grade")]
        [Validation(Required=false)]
        public int? Grade { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18704330000</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1212312312312</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
