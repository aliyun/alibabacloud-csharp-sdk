// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The specifications of the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values when the cluster is of Single-replica Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>S4-NEW</b></description></item>
        /// <item><description><b>S8</b></description></item>
        /// <item><description><b>S16</b></description></item>
        /// <item><description><b>S32</b></description></item>
        /// <item><description><b>S64</b></description></item>
        /// <item><description><b>S104</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values when the cluster is of Double-replica Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>C4-NEW</b></description></item>
        /// <item><description><b>C8</b></description></item>
        /// <item><description><b>C16</b></description></item>
        /// <item><description><b>C32</b></description></item>
        /// <item><description><b>C64</b></description></item>
        /// <item><description><b>C104</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S4-NEW</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp19lo45sy98x****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the cluster.</para>
        /// <list type="bullet">
        /// <item><description>If the cluster is of Single-replica Edition, the value must be an integer that ranges from 1 to 48.</description></item>
        /// <item><description>If the cluster is of Double-replica Edition, the value must be an integer that ranges from 1 to 24.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The storage capacity of a single node of the cluster. Unit: GB.</para>
        /// <para>Valid values: 100 to 32000.</para>
        /// <remarks>
        /// <para> This value is a multiple of 100.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CloudESSD</para>
        /// </summary>
        [NameInMap("DbNodeStorageType")]
        [Validation(Required=false)]
        public string DbNodeStorageType { get; set; }

        [NameInMap("DisableWriteWindows")]
        [Validation(Required=false)]
        public string DisableWriteWindows { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/170875.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
