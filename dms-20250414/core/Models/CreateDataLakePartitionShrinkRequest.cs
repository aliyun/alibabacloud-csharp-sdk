// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataLakePartitionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data catalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore an exception if a partition with the same name already exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IfNotExists")]
        [Validation(Required=false)]
        public bool? IfNotExists { get; set; }

        /// <summary>
        /// <para>Specifies whether to return information about the new partition. If you set this parameter to <b>true</b>, the Partition parameter is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Returns information about the new partition.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Does not return information about the new partition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedResult")]
        [Validation(Required=false)]
        public bool? NeedResult { get; set; }

        /// <summary>
        /// <para>The information about the new partition.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PartitionInput")]
        [Validation(Required=false)]
        public string PartitionInputShrink { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>Hover over your profile picture in the upper-right corner of the DMS console to obtain the tenant ID. For details, see <a href="https://help.aliyun.com/document_detail/181330.html">View tenant information</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
