// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The name of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-connector</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <para>The type of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("ConnectorType")]
        [Validation(Required=false)]
        public string ConnectorType { get; set; }

        /// <summary>
        /// <para>The description for the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文件连接器</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The parameters for the file connector.</para>
        /// </summary>
        [NameInMap("FileConnectorConfig")]
        [Validation(Required=false)]
        public AddConnectorRequestFileConnectorConfig FileConnectorConfig { get; set; }
        public class AddConnectorRequestFileConnectorConfig : TeaModel {
            /// <summary>
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zyb-docker-registry-jn</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The region of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The file storage location. Valid values:<br><c>OSS_CUSTOM</c>: Use your own Object Storage Service (OSS) bucket.<br><c>OSS_PLATFORM</c>: Use the platform-provided OSS bucket.<br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS_CUSTOM</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

    }

}
