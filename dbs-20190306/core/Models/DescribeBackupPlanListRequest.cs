// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup schedule. You can query multiple backup schedule IDs. Separate multiple IDs with commas (,).</para>
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
        /// <para>Backup plan status, the values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>wait</b>: Not configured</description></item>
        /// <item><description><b>init</b>: Not started (pre-check failed)</description></item>
        /// <item><description><b>running</b>: Running</description></item>
        /// <item><description><b>stop</b>: Failed</description></item>
        /// <item><description><b>pause</b>: Paused</description></item>
        /// <item><description><b>locked</b>: Locked</description></item>
        /// <item><description><b>check_pass</b>: Pre-check passed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wait</para>
        /// </summary>
        [NameInMap("BackupPlanStatus")]
        [Validation(Required=false)]
        public string BackupPlanStatus { get; set; }

        /// <summary>
        /// <para>Used to ensure the idempotence of the request, preventing duplicate submissions.</para>
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
        /// <para>Page number, must be greater than or equal to 0 and not exceed the maximum value of Integer. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of records per page, the value should be between 1 and 100.</para>
        /// <remarks>
        /// <para>The default is <b>30</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>DBS region, you can view the supported DBS regions by calling the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> interface.</para>
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

    }

}
