// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SaveEnvRequest : TeaModel {
        /// <summary>
        /// <para>The JMeter environment.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public SaveEnvRequestEnv Env { get; set; }
        public class SaveEnvRequestEnv : TeaModel {
            /// <summary>
            /// <para>The ID of the JMeter environment. To create a JMeter environment, leave this parameter empty. To update a JMeter environment, specify the ID of the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10YPA8H</para>
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <para>The name of the environment.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-create</para>
            /// </summary>
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            /// <summary>
            /// <para>The files on which the environment depends.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<SaveEnvRequestEnvFiles> Files { get; set; }
            public class SaveEnvRequestEnvFiles : TeaModel {
                /// <summary>
                /// <para>The name of the file. Make sure that the file name is the same as the file name in the value of <b>FileOssAddress</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>json.jar</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The Object Storage Service (OSS) URL of the file. Make sure that the file is accessible from the Internet.</para>
                /// <remarks>
                /// <para> Only OSS URLs in the China (Shanghai) region are supported.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://test.oss-cn-shanghai.aliyuncs.com/json.jar">https://test.oss-cn-shanghai.aliyuncs.com/json.jar</a></para>
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

            }

            /// <summary>
            /// <para>The extension label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("JmeterPluginLabel")]
            [Validation(Required=false)]
            public string JmeterPluginLabel { get; set; }

            /// <summary>
            /// <para>The JMeter attributes.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<SaveEnvRequestEnvProperties> Properties { get; set; }
            public class SaveEnvRequestEnvProperties : TeaModel {
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

        }

    }

}
