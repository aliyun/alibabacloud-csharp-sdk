// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateDataProcessJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the data processing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image data processing task</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The JSON string for the destination database connection configuration, which includes the account and password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Account&quot;:&quot;example_user&quot;,&quot;Password&quot;:&quot;example_password&quot;}</para>
        /// </summary>
        [NameInMap("DestinationConfig")]
        [Validation(Required=false)]
        public string DestinationConfig { get; set; }

        /// <summary>
        /// <para>The ID of the destination PolarDB cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-test123456</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// <para>The name of the destination database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DestinationPath")]
        [Validation(Required=false)]
        public string DestinationPath { get; set; }

        /// <summary>
        /// <para>The destination type. Currently, only PolarDB is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDB</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The name of the model used for feature extraction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-v1</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The processing mode. Valid values: Full, Incremental, and Both.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("ProcessingMode")]
        [Validation(Required=false)]
        public string ProcessingMode { get; set; }

        /// <summary>
        /// <para>The ID of the region where the task resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The additional configuration for the data source in JSON string format. You can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfig { get; set; }

        /// <summary>
        /// <para>The ID of the PolarFS instance that serves as the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-123456</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source data path in PolarFS. An empty string indicates the default path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/images</para>
        /// </summary>
        [NameInMap("SourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The data source type. Currently, only PolarFS is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarFS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the task template used to process data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-123456</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
