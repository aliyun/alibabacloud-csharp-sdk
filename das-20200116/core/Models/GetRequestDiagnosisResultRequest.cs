// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetRequestDiagnosisResultRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-0iwhhl8gx0ld6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The unique diagnosis ID returned by the <a href="https://help.aliyun.com/document_detail/341609.html">CreateRequestDiagnosis</a> operation.</para>
        /// <remarks>
        /// <para>If <c>MessageId</c> is the diagnosis ID for automatic SQL optimization, this operation does not return diagnosis results.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61820b594664275c4429****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>This parameter is required for cluster instances such as PolarDB for MySQL, PolarDB for PostgreSQL (Oracle-compatible), and ApsaraDB for MongoDB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>202****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The source of the task.</para>
        /// <remarks>
        /// <para>This parameter is for internal use by the DAS console. You do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The SQL template ID.</para>
        /// <remarks>
        /// <para>This parameter is for internal use by the DAS console. You do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

    }

}
