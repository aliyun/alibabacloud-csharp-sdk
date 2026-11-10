// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListRequest : TeaModel {
        /// <summary>
        /// <para>The backup method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan. You can specify multiple backup plan IDs, separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01exXXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The name of the backup plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>The status of the backup plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wait</b>: The backup plan is not configured.</para>
        /// </description></item>
        /// <item><description><para><b>init</b>: The backup plan is not started because a precheck failed.</para>
        /// </description></item>
        /// <item><description><para><b>running</b>: The backup plan is running.</para>
        /// </description></item>
        /// <item><description><para><b>stop</b>: The backup plan has failed.</para>
        /// </description></item>
        /// <item><description><para><b>pause</b>: The backup plan is paused.</para>
        /// </description></item>
        /// <item><description><para><b>locked</b>: The backup plan is locked.</para>
        /// </description></item>
        /// <item><description><para><b>check_pass</b>: The precheck is passed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wait</para>
        /// </summary>
        [NameInMap("BackupPlanStatus")]
        [Validation(Required=false)]
        public string BackupPlanStatus { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASDASDASDSADASFCZXVZ</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number to return. The value must be an integer that is greater than or equal to 0. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>The default value is <b>30</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the backup plan is located. You can call the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> operation to query the list of supported regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about the backup strategy. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowBackupStrategyInfo")]
        [Validation(Required=false)]
        public bool? ShowBackupStrategyInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the recovery time range. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowRecoverTimeRange")]
        [Validation(Required=false)]
        public bool? ShowRecoverTimeRange { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about the storage strategy. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowStorageStrategyInfo")]
        [Validation(Required=false)]
        public bool? ShowStorageStrategyInfo { get; set; }

    }

}
