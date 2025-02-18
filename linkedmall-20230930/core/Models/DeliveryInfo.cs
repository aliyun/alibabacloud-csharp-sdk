// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DeliveryInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>快递 免邮</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("postFee")]
        [Validation(Required=false)]
        public long? PostFee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-4</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public long? ServiceType { get; set; }

    }

}
