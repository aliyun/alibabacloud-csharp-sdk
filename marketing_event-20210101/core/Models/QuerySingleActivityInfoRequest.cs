// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class QuerySingleActivityInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12233445</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("QRCode")]
        [Validation(Required=false)]
        public string QRCode { get; set; }

    }

}
