// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePendingMaintenanceActionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the historical tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: returns the current task.</description></item>
        /// <item><description><b>1</b>: returns the historical tasks.</description></item>
        /// </list>
        /// <para>Default value: <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsHistory")]
        [Validation(Required=false)]
        public int? IsHistory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Specify the parameter to a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query the regions and zones that are supported by PolarDB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can set this parameter to <b>all</b> to view all pending events within your account.</description></item>
        /// <item><description>If you set <c>Region</c> to <b>all</b>, you must set <c>TaskType</c> to <b>all</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The task type of pending events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DatabaseSoftwareUpgrading</b>: database software upgrades</description></item>
        /// <item><description><b>DatabaseHardwareMaintenance</b>: hardware maintenance and upgrades</description></item>
        /// <item><description><b>DatabaseStorageUpgrading</b>: database storage upgrades</description></item>
        /// <item><description><b>DatabaseProxyUpgrading</b>: minor version upgrades of the proxy</description></item>
        /// <item><description><b>all</b>: queries the details of the pending events of all preceding types.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the <c>Region</c> parameter is set to <b>all</b>, the <c>TaskType</c> parameter must be set to <b>all</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
