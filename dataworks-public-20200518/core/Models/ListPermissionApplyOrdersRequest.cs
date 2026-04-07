// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The type of permission request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MaxComputeTable: Permission request for MaxCompute tables</description></item>
        /// <item><description>MaxComputeFunction: Permission request for MaxCompute functions</description></item>
        /// <item><description>MaxComputeResource: Permission request for MaxCompute resources</description></item>
        /// <item><description>DLFSchema: Permission request for DLF 1.0 schemas</description></item>
        /// <item><description>DLFTable: Permission request for DLF 1.0 tables</description></item>
        /// <item><description>DLFColumn: Permission request for DLF 1.0 columns</description></item>
        /// <item><description>DsApiDeploy: Permission request for publishing data services</description></item>
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
        /// <para>The end of the time range to query. You can query all the permissions request orders that have been submitted before the time. The parameter value is a UNIX timestamp. If you do not specify the parameter, all permission request orders that are submitted before the current time are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1617200471885</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not take effect.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>odps</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The status of the permission request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Pending approval</description></item>
        /// <item><description>2: Approved and authorization succeeded</description></item>
        /// <item><description>3: Approved but authorization failed</description></item>
        /// <item><description>4: Rejected</description></item>
        /// <item><description>5: Withdrawn</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0</description></item>
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public int? FlowStatus { get; set; }

        /// <summary>
        /// <para>The name of the MaxCompute project with which the permission request order is associated. If you do not specify the parameter, the permission request orders of all MaxCompute projects are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aMaxComputeProject</para>
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and does not take effect.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>0</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        /// <summary>
        /// <para>The page number for pagination. The value must be a positive integer greater than or equal to 1. Default value: 1.</para>
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
        /// <para>The query type for permission requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Permission requests submitted by me</description></item>
        /// <item><description>1: Permission requests pending my approval</description></item>
        /// <item><description>2: All permission requests</description></item>
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
        /// <para>The beginning of the time range to query. You can query all the permissions request orders that have been submitted after the time. The parameter value is a UNIX timestamp. If you do not specify the parameter, all permission request orders are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1616200471885</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The name of the table with which the permission request order is associated. If you do not specify the parameter, the permission request orders of all tables are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aTableName</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the permission request belongs. If you do not specify this parameter, permission requests from all workspaces are returned. To obtain the workspace ID, log on to the DataWorks console and navigate to the workspace configuration page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
