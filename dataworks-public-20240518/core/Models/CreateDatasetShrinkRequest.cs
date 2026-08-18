// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDatasetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the dataset. The value can be up to 1024 characters in length.</para>
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
        /// <item><description>COMMON: general-purpose (default).</description></item>
        /// <item><description>PIC: image.</description></item>
        /// <item><description>TEXT: text.</description></item>
        /// <item><description>TABLE: table.</description></item>
        /// <item><description>VIDEO: video.</description></item>
        /// <item><description>AUDIO: audio.</description></item>
        /// <item><description>INDEX: index.</description></item>
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
        /// <para>The name of the dataset. The value must be a non-empty string that is up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_oss_dataset</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The origin of the dataset. Only DataWorks is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataWorks</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: Object Storage Service.</description></item>
        /// <item><description>NAS: general-purpose NAS file storage.</description></item>
        /// <item><description>EXTREMENAS: extreme NAS file storage.</description></item>
        /// <item><description>DLF_LANCE: Data Lake Formation.</description></item>
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
