// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobNameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The new name of the task.</para>
        /// <remarks>
        /// <para>Configure a descriptive name that has business meaning (uniqueness is not required) for easy identification.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS间迁移</para>
        /// </summary>
        [NameInMap("DtsJobName")]
        [Validation(Required=false)]
        public string DtsJobName { get; set; }

        /// <summary>
        /// <para>The region ID of the task. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzfkjjb5gyy6i</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a seamless integration (zero-ETL) node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The node is a seamless integration (zero-ETL) node.</description></item>
        /// <item><description><b>false</b>: The node is not a seamless integration (zero-ETL) node.</description></item>
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
