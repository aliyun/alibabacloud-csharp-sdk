// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GoodsShippingNoticeCreateCmd : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SF</para>
        /// </summary>
        [NameInMap("cpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6693****4352</para>
        /// </summary>
        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SF145****4351</para>
        /// </summary>
        [NameInMap("logisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

    }

}
