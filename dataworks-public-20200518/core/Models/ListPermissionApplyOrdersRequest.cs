// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>[MaxComputeTable] MaxCompute table permission application order.</description></item>
        /// <item><description>[MaxComputeFunction] MaxCompute function application order.</description></item>
        /// <item><description>[MaxComputeResource] MaxCompute resource application order.</description></item>
        /// <item><description>[DLFSchema] DLF 1.0 schema permission application order.</description></item>
        /// <item><description>[DLFTable] DLF 1.0 table permission application order.</description></item>
        /// <item><description>[DLFColumn] DLF 1.0 column permission application order.</description></item>
        /// <item><description>[DsApiDeploy] DataService publishing permission application order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaxComputeTable</para>
        /// </summary>
        [NameInMap("ApplyType")]
        [Validation(Required=false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// <para>The name of the data catalog to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The end time for querying application orders, specified as a UNIX timestamp. If this parameter is not specified, application orders up to the current time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1617200471885</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The status of the application order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Pending approval.</description></item>
        /// <item><description>2: Approved, authorization succeeded.</description></item>
        /// <item><description>3: Approved, authorization failed.</description></item>
        /// <item><description>4: Rejected.</description></item>
        /// <item><description>5: Withdrawn.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public int? FlowStatus { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project to which the application order belongs. If this parameter is not specified, application orders from all MaxCompute projects are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMaxComputeProject</para>
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        /// <summary>
        /// <para>The page number for paginated queries. The value must be a positive integer greater than or equal to 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query type of the application order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Application orders submitted by me.</description></item>
        /// <item><description>1: Application orders approved by me.</description></item>
        /// <item><description>2: All application orders.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public int? QueryType { get; set; }

        /// <summary>
        /// <para>The start time for querying application orders, specified as a UNIX timestamp. If this parameter is not specified, all application orders are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616200471885</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The table name included in the application order. If this parameter is not specified, application orders for all tables are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aTableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the application order belongs. If this parameter is not specified, application orders from all workspaces are returned. You can log on to the DataWorks console and go to the Workspace Settings page to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
