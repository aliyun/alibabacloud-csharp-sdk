// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobInfosRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort query results in ascending or descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The ancestor node IDs.</para>
        /// </summary>
        [NameInMap("extNodeIdList")]
        [Validation(Required=false)]
        public List<string> ExtNodeIdList { get; set; }

        [NameInMap("extNodeNameList")]
        [Validation(Required=false)]
        public List<string> ExtNodeNameList { get; set; }

        /// <summary>
        /// <para>The start timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672112000</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The job instance IDs.</para>
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The job owners.</para>
        /// </summary>
        [NameInMap("jobOwnerList")]
        [Validation(Required=false)]
        public List<string> JobOwnerList { get; set; }

        /// <summary>
        /// <para>The job priorities.</para>
        /// </summary>
        [NameInMap("priorityList")]
        [Validation(Required=false)]
        public List<long?> PriorityList { get; set; }

        /// <summary>
        /// <para>The project names.</para>
        /// </summary>
        [NameInMap("projectList")]
        [Validation(Required=false)]
        public List<string> ProjectList { get; set; }

        /// <summary>
        /// <para>The quota nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_nickname</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>The intelligent diagnostics tags.</para>
        /// </summary>
        [NameInMap("sceneTagList")]
        [Validation(Required=false)]
        public List<string> SceneTagList { get; set; }

        /// <summary>
        /// <para>The job signatures.</para>
        /// </summary>
        [NameInMap("signatureList")]
        [Validation(Required=false)]
        public List<string> SignatureList { get; set; }

        /// <summary>
        /// <para>The sorting columns.</para>
        /// </summary>
        [NameInMap("sortByList")]
        [Validation(Required=false)]
        public List<string> SortByList { get; set; }

        /// <summary>
        /// <para>The orders for the sorting columns.</para>
        /// </summary>
        [NameInMap("sortOrderList")]
        [Validation(Required=false)]
        public List<string> SortOrderList { get; set; }

        /// <summary>
        /// <para>The job states.</para>
        /// </summary>
        [NameInMap("statusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        [NameInMap("taskNameList")]
        [Validation(Required=false)]
        public List<string> TaskNameList { get; set; }

        /// <summary>
        /// <para>The end timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672112130</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The job types.</para>
        /// </summary>
        [NameInMap("typeList")]
        [Validation(Required=false)]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// <para>The column based on which you want to sort query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cuUsage</para>
        /// </summary>
        [NameInMap("orderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
