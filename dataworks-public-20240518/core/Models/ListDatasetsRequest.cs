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
        /// <item><description>COMMON</description></item>
        /// <item><description>PIC</description></item>
        /// <item><description>TEXT</description></item>
        /// <item><description>TABLE</description></item>
        /// <item><description>VIDEO</description></item>
        /// <item><description>AUDIO</description></item>
        /// <item><description>INDEX</description></item>
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
        /// <item><description>Asc: Ascending.</description></item>
        /// <item><description>Desc: Descending.</description></item>
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
        /// <item><description>DataWorks</description></item>
        /// <item><description>PAI</description></item>
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
        /// <item><description>ModifyTime: Modification time.</description></item>
        /// <item><description>CreateTime: Creation time.</description></item>
        /// <item><description>Name</description></item>
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
        /// <item><description>OSS</description></item>
        /// <item><description>NAS: General-purpose NAS file systems</description></item>
        /// <item><description>EXTREMENAS: Extreme NAS file systems</description></item>
        /// <item><description>DLF_LANCE: Data Lake Formation</description></item>
        /// <item><description>CPFS: Cloud Parallel File Storage</description></item>
        /// <item><description>BMCPFS: CPFS for Lingjun</description></item>
        /// <item><description>MAXCOMPUTE: MaxCompute table</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StorageTypeList")]
        [Validation(Required=false)]
        public List<string> StorageTypeList { get; set; }

    }

}
