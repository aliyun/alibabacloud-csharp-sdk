// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetAlgorithmResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Large language model training</para>
        /// </summary>
        [NameInMap("AlgorithmDescription")]
        [Validation(Required=false)]
        public string AlgorithmDescription { get; set; }

        /// <summary>
        /// <para>The algorithm ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>algo-xsldfvu1334</para>
        /// </summary>
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// <para>The algorithm name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The algorithm provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <para>The display name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The time when the algorithm was created. The time follows the ISO 8601 standard in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the algorithm was last updated. The time follows the ISO 8601 standard in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant to whom the algorithm belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user to whom the algorithm belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
