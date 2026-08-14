// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SkipFullJobTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration, synchronization, or change tracking task. This parameter is deprecated and no longer takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The primary key ID of JobProgress. Each object in a full data migration task corresponds to a JobProgress entry. Specify this parameter to identify the table to skip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("JobProgressId")]
        [Validation(Required=false)]
        public string JobProgressId { get; set; }

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
        /// <para>rg-aek2ilvoxlrdcby</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The node is a zero-ETL node.</description></item>
        /// <item><description><b>false</b>: The node is not a zero-ETL node.</description></item>
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
