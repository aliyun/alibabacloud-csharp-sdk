// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListEnvsResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code. If the operation is successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The environments.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<ListEnvsResponseBodyEnvs> Envs { get; set; }
        public class ListEnvsResponseBodyEnvs : TeaModel {
            /// <summary>
            /// <para>The time when the environment was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637053715165</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86S1LH</para>
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The name of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-create</para>
            /// </summary>
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            /// <summary>
            /// <para>The JMeter version of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("EnvVersion")]
            [Validation(Required=false)]
            public string EnvVersion { get; set; }

            /// <summary>
            /// <para>The JAR files.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsFiles> Files { get; set; }
            public class ListEnvsResponseBodyEnvsFiles : TeaModel {
                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61660</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>json.jar</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The OSS address of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/json.jar">https://test.oss-cn-shanghai.aliyuncs.com/json.jar</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

                /// <summary>
                /// <para>The size of the file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>788</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The MD5 checksum of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43B584026CE5E570F3DE638FA7EEF9E0</para>
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

            }

            /// <summary>
            /// <para>The time when the environment was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637053719165</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The JMeter attributes.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsProperties> Properties { get; set; }
            public class ListEnvsResponseBodyEnvsProperties : TeaModel {
                /// <summary>
                /// <para>The description of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>远程主机</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remote_hosts</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the attribute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The scenarios related to the environment.</para>
            /// </summary>
            [NameInMap("RelatedScenes")]
            [Validation(Required=false)]
            public List<string> RelatedScenes { get; set; }

            /// <summary>
            /// <para>The IDs of the scenarios that run in the environment.</para>
            /// </summary>
            [NameInMap("RunningScenes")]
            [Validation(Required=false)]
            public List<string> RunningScenes { get; set; }

            /// <summary>
            /// <para>The total size of the environment file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26668</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. If the operation is successful, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. If the operation is successful, this parameter is not returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of environments per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8E16480-15C1-555A-922F-B736A005E52D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of environments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
