// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAgentStatisticsRequest : TeaModel {
        [NameInMap("AgentIds")]
        [Validation(Required=false)]
        public List<long?> AgentIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DepIds")]
        [Validation(Required=false)]
        public List<long?> DepIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617761765000</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistAgentGrouping")]
        [Validation(Required=false)]
        public bool? ExistAgentGrouping { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExistDepartmentGrouping")]
        [Validation(Required=false)]
        public bool? ExistDepartmentGrouping { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1615083365000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("TimeLatitudeType")]
        [Validation(Required=false)]
        public string TimeLatitudeType { get; set; }

    }

}
