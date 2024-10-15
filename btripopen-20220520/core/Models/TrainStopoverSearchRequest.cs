// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStopoverSearchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("arr_station")]
        [Validation(Required=false)]
        public string ArrStation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dep_station")]
        [Validation(Required=false)]
        public string DepStation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-08</para>
        /// </summary>
        [NameInMap("train_date")]
        [Validation(Required=false)]
        public string TrainDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k2345</para>
        /// </summary>
        [NameInMap("train_no")]
        [Validation(Required=false)]
        public string TrainNo { get; set; }

    }

}
