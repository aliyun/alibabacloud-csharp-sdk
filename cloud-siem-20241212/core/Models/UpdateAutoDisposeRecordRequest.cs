// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateAutoDisposeRecordRequest : TeaModel {
        /// <summary>
        /// <para>The conclusion of the automatic alert analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>疑似误报</para>
        /// </summary>
        [NameInMap("AutoDecisionConclusion")]
        [Validation(Required=false)]
        public string AutoDecisionConclusion { get; set; }

        /// <summary>
        /// <para>The list of entities for analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;entityType&quot;:&quot;file&quot;,&quot;entityName&quot;:&quot;/path/file.file&quot;,&quot;entityUuid&quot;:&quot;b7efb45ce7ff09758****&quot;,&quot;disposalMethod&quot;:&quot;delete&quot;,&quot;playbookUuid&quot;:&quot;9213bhdjagdja****&quot;}]</para>
        /// </summary>
        [NameInMap("AutoDecisionEntityList")]
        [Validation(Required=false)]
        public string AutoDecisionEntityList { get; set; }

        /// <summary>
        /// <para>The analysis result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("AutoDecisionResult")]
        [Validation(Required=false)]
        public string AutoDecisionResult { get; set; }

        /// <summary>
        /// <para>The unique ID of the analysis record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4227e0cdc4b7efb45ce7ff09758****</para>
        /// </summary>
        [NameInMap("AutoDisposeRecordId")]
        [Validation(Required=false)]
        public string AutoDisposeRecordId { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
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
