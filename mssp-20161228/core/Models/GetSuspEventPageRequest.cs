// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspEventPageRequest : TeaModel {
        /// <summary>
        /// <para>Alarm end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732515522000</para>
        /// </summary>
        [NameInMap("AlarmEndTime")]
        [Validation(Required=false)]
        public long? AlarmEndTime { get; set; }

        /// <summary>
        /// <para>Alarm start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722515522000</para>
        /// </summary>
        [NameInMap("AlarmStartTime")]
        [Validation(Required=false)]
        public long? AlarmStartTime { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Alarm source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUSP_EVENT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Disposal status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
