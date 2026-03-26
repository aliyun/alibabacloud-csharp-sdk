// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Dataset : TeaModel {
        /// <summary>
        /// <para>The description of the dataset. The length cannot exceed 1024 characters.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736756055000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210484359</para>
        /// </summary>
        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>COMMON</description></item>
        /// <item><description>PIC</description></item>
        /// <item><description>TEXT</description></item>
        /// <item><description>TABLE</description></item>
        /// <item><description>VIDEO</description></item>
        /// <item><description>AUDIO</description></item>
        /// <item><description>INDEX</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks-dataset:1gxxxqjx155usz3hrv</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Dataset tags. Supported only for PAI datasets.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<DatasetLabel> Labels { get; set; }

        /// <summary>
        /// <para>The latest dataset version object.</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public DatasetVersion LatestVersion { get; set; }

        /// <summary>
        /// <para>The modification time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736756055000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The dataset name. It must be a non-empty string and cannot exceed 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the dataset. Currently supported sources:</para>
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
        /// <para>The DataWorks workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Instructions for using the dataset. Markdown rich text is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>introduction</h2>
        /// </summary>
        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Object Storage Service</description></item>
        /// <item><description>NAS: General-purpose NAS file systems</description></item>
        /// <item><description>EXTREM_NAS: Extreme NAS file systems</description></item>
        /// <item><description>DLF_LANCE: Data Lake Formation</description></item>
        /// <item><description>CPFS: Cloud Paralleled File System</description></item>
        /// <item><description>BMCPFS: CPFS for Lingjun</description></item>
        /// <item><description>MAXCOMPUTE: MaxCompute table</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
