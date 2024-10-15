// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoInfoSearchRequest : TeaModel {
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
        /// <para>2023-08-15</para>
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
        /// <b>Example:</b>
        /// <para>qwwweqswxxa</para>
        /// </summary>
        [NameInMap("line_key")]
        [Validation(Required=false)]
        public string LineKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-15</para>
        /// </summary>
        [NameInMap("middle_date")]
        [Validation(Required=false)]
        public string MiddleDate { get; set; }

        [NameInMap("middle_station")]
        [Validation(Required=false)]
        public string MiddleStation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12342123212</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>K2345</para>
        /// </summary>
        [NameInMap("train_no")]
        [Validation(Required=false)]
        public string TrainNo { get; set; }

    }

}
