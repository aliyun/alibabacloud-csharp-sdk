// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i03e3zty16i****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The task code that specifies the type of the DTS subtask. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>01</b>: precheck.</description></item>
        /// <item><description><b>02</b>: schema migration or initial schema synchronization.</description></item>
        /// <item><description><b>03</b>: full data migration or initial full data synchronization.</description></item>
        /// <item><description><b>04</b>: incremental data migration or synchronization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// <para>The filter item used to filter tables in fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuprop</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz4us4iruleja</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The filter item used to filter tables, views, and functions during schema migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>View</para>
        /// </summary>
        [NameInMap("StructPhase")]
        [Validation(Required=false)]
        public string StructPhase { get; set; }

        /// <summary>
        /// <para>The type of schema definition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>before</b>: schema migration or initial schema synchronization.</description></item>
        /// <item><description><b>after</b>: DDL operations performed during incremental data migration or synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>before</para>
        /// </summary>
        [NameInMap("StructType")]
        [Validation(Required=false)]
        public string StructType { get; set; }

        /// <summary>
        /// <para>Whether it is a seamless integration (Zero-ETL) task, the value can be:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: No. - <b>true</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
