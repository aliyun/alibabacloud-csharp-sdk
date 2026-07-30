// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoInfoSearchRequest : TeaModel {
        /// <summary>
        /// <para>The code of the arrival station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包头东</para>
        /// </summary>
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        /// <summary>
        /// <para>The date of the train service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-15</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>The code of the departure station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包头</para>
        /// </summary>
        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        /// <summary>
        /// <para>The unique route identifier. This parameter is required for transfer routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwwweqswxxa</para>
        /// </summary>
        [NameInMap("line_key")]
        [Validation(Required=false)]
        public string LineKey { get; set; }

        /// <summary>
        /// <para>The transfer date. This parameter is required for transfer routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-15</para>
        /// </summary>
        [NameInMap("middle_date")]
        [Validation(Required=false)]
        public string MiddleDate { get; set; }

        /// <summary>
        /// <para>The transfer station. This parameter is required for transfer routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>兰州西</para>
        /// </summary>
        [NameInMap("middle_station")]
        [Validation(Required=false)]
        public string MiddleStation { get; set; }

        /// <summary>
        /// <para>The business travel order ID. This parameter is required for ticket changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12342123212</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The train number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K2345</para>
        /// </summary>
        [NameInMap("train_no")]
        [Validation(Required=false)]
        public string TrainNo { get; set; }

    }

}
