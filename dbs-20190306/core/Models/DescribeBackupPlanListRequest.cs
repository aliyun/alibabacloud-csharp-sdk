// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>logical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>Backup plan ID. To list multiple backup plans, separate IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01exXXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>Backup plan name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>Backup plan status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wait</b>: Not configured.</para>
        /// </description></item>
        /// <item><description><para><b>init</b>: Not started (precheck failed).</para>
        /// </description></item>
        /// <item><description><para><b>running</b>: Running.</para>
        /// </description></item>
        /// <item><description><para><b>stop</b>: Failed.</para>
        /// </description></item>
        /// <item><description><para><b>pause</b>: Paused.</para>
        /// </description></item>
        /// <item><description><para><b>locked</b>: Locked.</para>
        /// </description></item>
        /// <item><description><para><b>check_pass</b>: Precheck passed.</para>
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
        /// <para>A client token used to ensure idempotence and prevent duplicate requests.</para>
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
        /// <para>Page number. Valid values: integers greater than or equal to 0 and less than or equal to the maximum integer value. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of records per page. Valid values: 1 to 100.</para>
        /// <remarks>
        /// <para>Default value: <b>30</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>DBS region. Call <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> to view supported regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ShowBackupStrategyInfo")]
        [Validation(Required=false)]
        public bool? ShowBackupStrategyInfo { get; set; }

        [NameInMap("ShowRecoverTimeRange")]
        [Validation(Required=false)]
        public bool? ShowRecoverTimeRange { get; set; }

        [NameInMap("ShowStorageStrategyInfo")]
        [Validation(Required=false)]
        public bool? ShowStorageStrategyInfo { get; set; }

    }

}
