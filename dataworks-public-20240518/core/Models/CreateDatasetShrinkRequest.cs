// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset. It must not exceed 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>COMMON: Common (Default)</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>COMMON</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>The initial version of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InitVersion")]
        [Validation(Required=false)]
        public string InitVersionShrink { get; set; }

        /// <summary>
        /// <para>The name of the dataset. It cannot be an empty string and must not exceed 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_oss_dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the dataset. Currently, only DataWorks is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataWorks</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The storage type. Currently supported values:</para>
        /// <list type="bullet">
        /// <item><description><para>OSS</para>
        /// </description></item>
        /// <item><description><para>NAS: General-purpose NAS file systems</para>
        /// </description></item>
        /// <item><description><para>EXTREMENAS: Extreme NAS file systems</para>
        /// </description></item>
        /// <item><description><para>DLF_LANCE: Data Lake Formation</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NAS: General-purpose NAS file systems</para>
        /// </description></item>
        /// <item><description><para>MAXCOMPUTE: MaxCompute table</para>
        /// </description></item>
        /// <item><description><para>CPFS: Cloud Parallel File Storage</para>
        /// </description></item>
        /// <item><description><para>BMCPFS: CPFS for Lingjun</para>
        /// </description></item>
        /// <item><description><para>EXTREMENAS: Extreme NAS file systems</para>
        /// </description></item>
        /// <item><description><para>OSS: Object Storage Service</para>
        /// </description></item>
        /// <item><description><para>DLF_LANCE: Data Lake Formation.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
