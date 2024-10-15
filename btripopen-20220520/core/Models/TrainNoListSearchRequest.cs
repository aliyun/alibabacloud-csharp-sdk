// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoListSearchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-16</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public TrainNoListSearchRequestOption Option { get; set; }
        public class TrainNoListSearchRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("need_transfer")]
            [Validation(Required=false)]
            public bool? NeedTransfer { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
