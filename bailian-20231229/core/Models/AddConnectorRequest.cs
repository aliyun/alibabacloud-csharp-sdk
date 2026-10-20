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
        /// <para>The description of the connector.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File connector</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration parameters for the file connector.</para>
        /// </summary>
        [NameInMap("FileConnectorConfig")]
        [Validation(Required=false)]
        public AddConnectorRequestFileConnectorConfig FileConnectorConfig { get; set; }
        public class AddConnectorRequestFileConnectorConfig : TeaModel {
            /// <summary>
            /// <para>The name of the storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zyb-docker-registry-jn</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The region of the storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The file storage location. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS_CUSTOM: Use your own OSS storage. </description></item>
            /// <item><description>OSS_PLATFORM: Use platform OSS storage.</description></item>
            /// </list>
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
