// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the task can be canceled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The task cannot be canceled.</description></item>
        /// <item><description><b>1</b>: The task can be canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the time can be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The time cannot be modified.</description></item>
        /// <item><description><b>1</b>: The time can be modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The change level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>S0</b>: Exception fix.</description></item>
        /// <item><description><b>S1</b>: System O&amp;M.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S1</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hbaseue</b>: ApsaraDB for HBase Enhanced Edition.</description></item>
        /// <item><description><b>hbase</b>: ApsaraDB for HBase Standard Edition.</description></item>
        /// <item><description><b>bds</b>: BDS data synchronization service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hbaseue</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The HBase instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than <b>0</b> and cannot exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records that can be displayed per page. The value must be greater than <b>10</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product name. Default value: <b>hbase</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID of the event to be processed. You can call <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> to obtain the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// <para>The task running status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Waiting for the user to specify a time.</description></item>
        /// <item><description><b>3</b>: Waiting for processing.</description></item>
        /// <item><description><b>4</b>: Processing.</description></item>
        /// <item><description><b>5</b>: Succeeded.</description></item>
        /// <item><description><b>6</b>: Failed.</description></item>
        /// <item><description><b>7</b>: Canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The task type. Set the value to <b>rds_apsaradb_upgrade</b>, which indicates a minor version upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_apsaradb_upgrade</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
