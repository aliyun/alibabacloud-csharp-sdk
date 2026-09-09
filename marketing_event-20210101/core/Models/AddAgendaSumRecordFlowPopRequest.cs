// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class AddAgendaSumRecordFlowPopRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ActiveNum")]
        [Validation(Required=false)]
        public int? ActiveNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AgendaId")]
        [Validation(Required=false)]
        public long? AgendaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90.81</para>
        /// </summary>
        [NameInMap("AttendancePercent")]
        [Validation(Required=false)]
        public string AttendancePercent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784443333333</para>
        /// </summary>
        [NameInMap("FlowTime")]
        [Validation(Required=false)]
        public long? FlowTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>云栖大会主论坛</para>
        /// </summary>
        [NameInMap("SessionName")]
        [Validation(Required=false)]
        public string SessionName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPv")]
        [Validation(Required=false)]
        public int? TotalPv { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalUv")]
        [Validation(Required=false)]
        public int? TotalUv { get; set; }

    }

}
