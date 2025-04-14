// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowsRequest : TeaModel {
        /// <summary>
        /// <para>The environment of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production environment</description></item>
        /// <item><description>Dev: development environment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The IDs of the workflows. You can query multiple workflows at a time by workflow ID.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The name of the workflow. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Workflow1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The account ID of the workflow owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Fields such as TriggerTime and StartedTime are supported. The value of this parameter is in the Sort field + Sort by (Desc/Asc) format. By default, results are sorted in ascending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ModifyTime (Desc/Asc)</description></item>
        /// <item><description>CreateTime (Desc/Asc)</description></item>
        /// <item><description>Id (Desc/Asc)</description></item>
        /// </list>
        /// <para>Default value: Id Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduler</description></item>
        /// <item><description>Manual</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduler</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
