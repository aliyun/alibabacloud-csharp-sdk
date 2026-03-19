// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeIncrementBackupListRequest : TeaModel {
        /// <summary>
        /// <para>The backup plan ID. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> interface to get this parameter\&quot;s value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsqdss5tmh****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A unique string that ensures the idempotence of the request and prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end backup UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361600</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 0 and less than or equal to the maximum integer value. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values are 30, 50, and 100.</para>
        /// <remarks>
        /// <para>The default number of entries per page is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether to display the storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowStorageType")]
        [Validation(Required=false)]
        public bool? ShowStorageType { get; set; }

        /// <summary>
        /// <para>The start backup UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570701361528</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

    }

}
