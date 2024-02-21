// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudbenchTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information, including the error codes and the number of entries that are returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudbenchTaskConfigResponseBodyData Data { get; set; }
        public class DescribeCloudbenchTaskConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The path in which the files are archived.
            /// </summary>
            [NameInMap("ArchiveFolder")]
            [Validation(Required=false)]
            public string ArchiveFolder { get; set; }

            /// <summary>
            /// The command that was run to start the stress testing task.
            /// </summary>
            [NameInMap("BenchCmd")]
            [Validation(Required=false)]
            public string BenchCmd { get; set; }

            /// <summary>
            /// The path to the JAR file that is used for stress testing.
            /// </summary>
            [NameInMap("ClientJarPath")]
            [Validation(Required=false)]
            public string ClientJarPath { get; set; }

            /// <summary>
            /// The path to the JAR file that is stored in OSS. The JAR file is used for stress testing.
            /// </summary>
            [NameInMap("JarOnOss")]
            [Validation(Required=false)]
            public string JarOnOss { get; set; }

            /// <summary>
            /// The command that was run to preload the file that stores the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("LoadCmd")]
            [Validation(Required=false)]
            public string LoadCmd { get; set; }

            /// <summary>
            /// The name of the metadata file.
            /// </summary>
            [NameInMap("MetaFileName")]
            [Validation(Required=false)]
            public string MetaFileName { get; set; }

            /// <summary>
            /// The name of the metadata file stored in Object Storage Service (OSS).
            /// </summary>
            [NameInMap("MetaFileOnOss")]
            [Validation(Required=false)]
            public string MetaFileOnOss { get; set; }

            /// <summary>
            /// The path to the metadata file.
            /// </summary>
            [NameInMap("MetaFilePath")]
            [Validation(Required=false)]
            public string MetaFilePath { get; set; }

            /// <summary>
            /// The command that was run to parse the file that stores the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("ParseCmd")]
            [Validation(Required=false)]
            public string ParseCmd { get; set; }

            /// <summary>
            /// The path to the file that is parsed. The file stores the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("ParseFilePath")]
            [Validation(Required=false)]
            public string ParseFilePath { get; set; }

            /// <summary>
            /// The location where the RocksDB storage system is deployed in the stress testing client.
            /// </summary>
            [NameInMap("RocksDbPath")]
            [Validation(Required=false)]
            public string RocksDbPath { get; set; }

            /// <summary>
            /// The name of the file that stores the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("SqlFileName")]
            [Validation(Required=false)]
            public string SqlFileName { get; set; }

            /// <summary>
            /// The name of the file that stores the analysis result of full SQL statistics and that is stored in OSS.
            /// </summary>
            [NameInMap("SqlFileOnOss")]
            [Validation(Required=false)]
            public string SqlFileOnOss { get; set; }

            /// <summary>
            /// The path to the file that stores the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("SqlFilePath")]
            [Validation(Required=false)]
            public string SqlFilePath { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The path of the temporary directory that is generated for stress testing.
            /// </summary>
            [NameInMap("WorkDir")]
            [Validation(Required=false)]
            public string WorkDir { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
