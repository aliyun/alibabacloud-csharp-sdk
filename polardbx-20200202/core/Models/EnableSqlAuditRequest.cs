// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class EnableSqlAuditRequest : TeaModel {
        /// <summary>
        /// <para>The name of the audit administrator account. &gt; If the three-authority separation mode is enabled, this parameter is required. For more information about the three-authority separation module, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-authority separation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_daa</para>
        /// </summary>
        [NameInMap("AuditAccountName")]
        [Validation(Required=false)]
        public string AuditAccountName { get; set; }

        /// <summary>
        /// <para>The password of the audit administrator account. &gt; If the three-authority separation mode is enabled, this parameter is required. For more information about the three-authority separation module, see <a href="https://help.aliyun.com/document_detail/213824.html">Three-authority separation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pw@11111</para>
        /// </summary>
        [NameInMap("AuditAccountPassword")]
        [Validation(Required=false)]
        public string AuditAccountPassword { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-****************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of days to retain audit logs:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Do not retain (i.e., disable automatic log expiration)</para>
        /// </description></item>
        /// <item><description><remarks>
        /// <para>0: Logs are automatically deleted after N days</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><remarks>
        /// <para>Common values: 30, 45, 90, 180, 365</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("ExpireAfterDays")]
        [Validation(Required=false)]
        public int? ExpireAfterDays { get; set; }

        /// <summary>
        /// <para>The region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
