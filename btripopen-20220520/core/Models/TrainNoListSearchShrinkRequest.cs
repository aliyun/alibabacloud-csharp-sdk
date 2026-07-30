// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoListSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The arrival station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包头东</para>
        /// </summary>
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        /// <summary>
        /// <para>The date of the train schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-16</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>The departure station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包头</para>
        /// </summary>
        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        /// <summary>
        /// <para>The query conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        /// <summary>
        /// <para>The order ID. This parameter is required when searching for ticket changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
