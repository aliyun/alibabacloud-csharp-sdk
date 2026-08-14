// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobDetailRequest : TeaModel {
        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailRequestMigrationMode MigrationMode { get; set; }
        public class DescribeMigrationJobDetailRequestMigrationMode : TeaModel {
            /// <summary>
            /// <para>Specifies whether to query the details of full data migration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.<remarks>
            /// <para>Default value: <b>false</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataInitialization")]
            [Validation(Required=false)]
            public bool? DataInitialization { get; set; }

            /// <summary>
            /// <para>Specifies whether to query the details of incremental data migration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.<remarks>
            /// <para>Default value: <b>false</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// <para>Specifies whether to query the details of schema migration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.<remarks>
            /// <para>Default value: <b>false</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StructureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because it will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a value from your client to ensure that the value is unique among different requests. The value of <b>ClientToken</b> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Instance ID of the data migration instance. You can call the <b>DescribeMigrationJobs</b> operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsta7w132u12h****</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer greater than <b>0</b> and must not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data migration instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
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
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
