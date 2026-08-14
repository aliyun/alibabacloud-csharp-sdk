// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SummaryJobDetailRequest : TeaModel {
        /// <summary>
        /// <para>The migration or synchronization instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration or synchronization task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The migration phase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>02</b>: schema migration phase.</description></item>
        /// <item><description><b>03</b>: incremental data migration phase.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2mjc4qlnog6q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of schema definition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>before</b>: schema migration or initial schema synchronization.</description></item>
        /// <item><description><b>after</b>: DDL operations during incremental data migration or synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>before</para>
        /// </summary>
        [NameInMap("StructType")]
        [Validation(Required=false)]
        public string StructType { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: forward.</description></item>
        /// <item><description><b>Reverse</b>: reverse.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can set this parameter to <b>Reverse</b> to release the reverse synchronization link only when the topology of the data synchronization instance is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The node is a seamless integration node.</description></item>
        /// <item><description><b>false</b>: The node is not a seamless integration node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
