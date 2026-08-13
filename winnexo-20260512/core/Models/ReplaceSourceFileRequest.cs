// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ReplaceSourceFileRequest : TeaModel {
        /// <summary>
        /// <para>新文件名（可选；不传或空字符串时保持原文件名）</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.pdf</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>新文件的 OSS 持久化地址（由上传签名接口返回）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>新文件的公开访问 URL（可能携带临时签名）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
        /// </summary>
        [NameInMap("filePublicUrl")]
        [Validation(Required=false)]
        public string FilePublicUrl { get; set; }

        /// <summary>
        /// <para>新文件的文件记录 ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleFileRecordId</para>
        /// </summary>
        [NameInMap("fileRecordId")]
        [Validation(Required=false)]
        public string FileRecordId { get; set; }

        /// <summary>
        /// <para>是否同步等待重新解析完成；默认 false，异步入队</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("forceSync")]
        [Validation(Required=false)]
        public bool? ForceSync { get; set; }

        /// <summary>
        /// <para>待替换的个人 FILE 数据源 ID（租户内唯一）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
