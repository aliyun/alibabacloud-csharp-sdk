// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ReplaceGroupSourceFileRequest : TeaModel {
        /// <summary>
        /// <para>The new file name. This parameter is optional. If you do not specify this parameter or set it to an empty string, the original file name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The OSS persistent storage path of the replacement file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example/new.txt</para>
        /// </summary>
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The OSS persistent storage path of the replacement file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/new.txt">https://example.com/new.txt</a></para>
        /// </summary>
        [NameInMap("filePublicUrl")]
        [Validation(Required=false)]
        public string FilePublicUrl { get; set; }

        /// <summary>
        /// <para>The file record ID of the replacement file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file_example</para>
        /// </summary>
        [NameInMap("fileRecordId")]
        [Validation(Required=false)]
        public string FileRecordId { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously wait for re-parsing to complete. Default value: false, which means the task is asynchronously enqueued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceSync")]
        [Validation(Required=false)]
        public bool? ForceSync { get; set; }

        /// <summary>
        /// <para>The project group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source_example</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass this parameter explicitly by using <c>--tenant-id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
