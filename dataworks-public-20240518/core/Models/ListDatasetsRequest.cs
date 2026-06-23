// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDatasetsRequest : TeaModel {
        /// <summary>
        /// <para>The creator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12103XXX46492139</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The data type. Multiple selections are allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMMON</para>
        /// </description></item>
        /// <item><description><para>PIC</para>
        /// </description></item>
        /// <item><description><para>TEXT</para>
        /// </description></item>
        /// <item><description><para>TABLE</para>
        /// </description></item>
        /// <item><description><para>VIDEO</para>
        /// </description></item>
        /// <item><description><para>AUDIO</para>
        /// </description></item>
        /// <item><description><para>INDEX</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("DataTypeList")]
        [Validation(Required=false)]
        public List<string> DataTypeList { get; set; }

        /// <summary>
        /// <para>The dataset name. Supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default: Desc.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Asc: Ascending.</para>
        /// </description></item>
        /// <item><description><para>Desc: Descending.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The dataset source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DataWorks</para>
        /// </description></item>
        /// <item><description><para>PAI</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataWorks</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number. Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>251363</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The sort field. Default: CreateTime.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ModifyTime: Modification time.</para>
        /// </description></item>
        /// <item><description><para>CreateTime: Creation time.</para>
        /// </description></item>
        /// <item><description><para>Name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The storage type. Multiple selections are allowed. Supported values:</para>
        /// <list type="bullet">
        /// <item><description><para>OSS</para>
        /// </description></item>
        /// <item><description><para>NAS: General-purpose NAS file systems</para>
        /// </description></item>
        /// <item><description><para>EXTREMENAS: Extreme NAS file systems</para>
        /// </description></item>
        /// <item><description><para>DLF_LANCE: Data Lake Formation</para>
        /// </description></item>
        /// <item><description><para>CPFS: Cloud Parallel File Storage</para>
        /// </description></item>
        /// <item><description><para>BMCPFS: CPFS for Lingjun</para>
        /// </description></item>
        /// <item><description><para>MAXCOMPUTE: MaxCompute table</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("StorageTypeList")]
        [Validation(Required=false)]
        public List<string> StorageTypeList { get; set; }

    }

}
