// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateSkillFileCheckRequest : TeaModel {
        /// <summary>
        /// <para>The file information.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<CreateSkillFileCheckRequestFiles> Files { get; set; }
        public class CreateSkillFileCheckRequestFiles : TeaModel {
            /// <summary>
            /// <para>The public URL for downloading the file. The downloaded file must be a compressed package in tar.gz or zip format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/xxxx">https://test.oss-cn-hangzhou.aliyuncs.com/xxxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The file name. If not specified, the file name is parsed from DownloadUrl.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-file</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The tenant-isolated OSS temporary object key returned by GenerateSkillOssUploadCredential. Specify either this parameter or DownloadUrl.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-upload/staging/123456789/550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("UploadKey")]
            [Validation(Required=false)]
            public string UploadKey { get; set; }

        }

        /// <summary>
        /// <para>The upload source. If left empty, the default value is user_upload. Use sec_ops_agent for the security operations agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sec_ops_agent</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
