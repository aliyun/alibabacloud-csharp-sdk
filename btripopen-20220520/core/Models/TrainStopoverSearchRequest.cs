// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStopoverSearchRequest : TeaModel {
        /// <summary>
        /// <para>The arrival station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>重庆西</para>
        /// </summary>
        [NameInMap("arr_station")]
        [Validation(Required=false)]
        public string ArrStation { get; set; }

        /// <summary>
        /// <para>The departure station.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>巫山站</para>
        /// </summary>
        [NameInMap("dep_station")]
        [Validation(Required=false)]
        public string DepStation { get; set; }

        /// <summary>
        /// <para>The departure date in the format yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-08</para>
        /// </summary>
        [NameInMap("train_date")]
        [Validation(Required=false)]
        public string TrainDate { get; set; }

        /// <summary>
        /// <para>The train number.</para>
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
