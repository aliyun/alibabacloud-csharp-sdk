// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UploadFileRequest : TeaModel {
        /// <summary>
        /// <para>The description of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试使用</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A custom file name. The name must be unique and serves as a unique identifier for the file. The name must meet the following requirements:</para>
        /// <ol>
        /// <item><description><para>It must be 8 to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It can contain lowercase letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// </description></item>
        /// <item><description><para>The first and last characters must be a letter or a digit.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytest</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the file. This is used to verify the integrity of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150b6083f50dd08159d45a0d5e4b56f9</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The download URL of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.xxx.xxx.tar">https://xxx.xxx.xxx.tar</a></para>
        /// </summary>
        [NameInMap("OriginUrl")]
        [Validation(Required=false)]
        public string OriginUrl { get; set; }

        /// <summary>
        /// <para>The destination path on the service instance. This must be an absolute path to a file. You cannot specify only a folder. The parent folder of the destination path is restricted to the following locations:</para>
        /// <ol>
        /// <item><description><para>/data/local</para>
        /// </description></item>
        /// <item><description><para>/data/user</para>
        /// </description></item>
        /// <item><description><para>/data/data</para>
        /// </description></item>
        /// <item><description><para>/data/cache</para>
        /// </description></item>
        /// <item><description><para>/data/tmp</para>
        /// </description></item>
        /// <item><description><para>/data/storage</para>
        /// </description></item>
        /// <item><description><para>/data/media/0</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/tmp/test/xxx.tar</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

    }

}
