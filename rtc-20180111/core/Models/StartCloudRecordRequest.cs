// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class StartCloudRecordRequest : TeaModel {
        /// <summary>
        /// appId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// channelName
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// panes
        /// </summary>
        [NameInMap("Panes")]
        [Validation(Required=false)]
        public List<StartCloudRecordRequestPanes> Panes { get; set; }
        public class StartCloudRecordRequestPanes : TeaModel {
            /// <summary>
            /// paneId
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("PaneId")]
            [Validation(Required=false)]
            public int? PaneId { get; set; }

            /// <summary>
            /// sourceType
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// storageConfig
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageConfig")]
        [Validation(Required=false)]
        public StartCloudRecordRequestStorageConfig StorageConfig { get; set; }
        public class StartCloudRecordRequestStorageConfig : TeaModel {
            /// <summary>
            /// accessKey
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// bucket
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// region
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public int? Region { get; set; }

            /// <summary>
            /// secretKey
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SecretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

            /// <summary>
            /// vendor
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// taskId
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// templateId
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
