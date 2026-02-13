// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class DocumentDetailItem : TeaModel {
        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-08T17:04:28.000+08:00</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5335c8828ccf735a500ed636590c713a94daf6cdacc90237733035cc5a152afb_1760513801010</para>
        /// </summary>
        [NameInMap("docHash")]
        [Validation(Required=false)]
        public string DocHash { get; set; }

        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://carbon-aidoc.oss-cn-hangzhou.aliyuncs.com/jobs/jobid/document/documentid/docName">https://carbon-aidoc.oss-cn-hangzhou.aliyuncs.com/jobs/jobid/document/documentid/docName</a></para>
        /// </summary>
        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>adafb91d4e014e2eb4d0a5375b547115</para>
        /// </summary>
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6731</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>74ec62f4f4e74e5882d4086a40f2b9c6</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PARSING_COMPLETED</para>
        /// </summary>
        [NameInMap("jobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("originDocName")]
        [Validation(Required=false)]
        public string OriginDocName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://carbon-aidoc.oss-cn-hangzhou.aliyuncs.com/jobs/jobid/document/documentid/originDocName">https://carbon-aidoc.oss-cn-hangzhou.aliyuncs.com/jobs/jobid/document/documentid/originDocName</a></para>
        /// </summary>
        [NameInMap("originDocUrl")]
        [Validation(Required=false)]
        public string OriginDocUrl { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-08T17:04:28.000+08:00</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
