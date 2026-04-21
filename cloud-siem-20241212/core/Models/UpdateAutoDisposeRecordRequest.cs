// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateAutoDisposeRecordRequest : TeaModel {
        [NameInMap("AutoDecisionConclusion")]
        [Validation(Required=false)]
        public string AutoDecisionConclusion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;entityType&quot;:&quot;file&quot;,&quot;entityName&quot;:&quot;/path/file.file&quot;,&quot;entityUuid&quot;:&quot;b7efb45ce7ff09758****&quot;,&quot;disposalMethod&quot;:&quot;delete&quot;,&quot;playbookUuid&quot;:&quot;9213bhdjagdja****&quot;}]</para>
        /// </summary>
        [NameInMap("AutoDecisionEntityList")]
        [Validation(Required=false)]
        public string AutoDecisionEntityList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("AutoDecisionResult")]
        [Validation(Required=false)]
        public string AutoDecisionResult { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4227e0cdc4b7efb45ce7ff09758****</para>
        /// </summary>
        [NameInMap("AutoDisposeRecordId")]
        [Validation(Required=false)]
        public string AutoDisposeRecordId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
