// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetSeatInformationRequest : TeaModel {
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("depIds")]
        [Validation(Required=false)]
        public List<long?> DepIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1617761765000</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("existDepartmentGrouping")]
        [Validation(Required=false)]
        public bool? ExistDepartmentGrouping { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1615083365000</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
