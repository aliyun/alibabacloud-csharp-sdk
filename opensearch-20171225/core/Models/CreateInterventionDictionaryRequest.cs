// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateInterventionDictionaryRequest : TeaModel {
        /// <summary>
        /// <para>The type of the analyzer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MODEL: model-based custom analyzer.</description></item>
        /// <item><description>SYSTEM: system analyzer.</description></item>
        /// <item><description>USER: custom analyzer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("analyzerType")]
        [Validation(Required=false)]
        public string AnalyzerType { get; set; }

        /// <summary>
        /// <para>The name of the intervention dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ner_dict_ec</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the intervention dictionary. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stopword: an intervention dictionary for stop word filtering.</description></item>
        /// <item><description>synonym: an intervention dictionary for synonym configuration.</description></item>
        /// <item><description>correction: an intervention dictionary for spelling correction.</description></item>
        /// <item><description>category_prediction: an intervention dictionary for category prediction.</description></item>
        /// <item><description>ner: an intervention dictionary for named entity recognition (NER).</description></item>
        /// <item><description>term_weighting: an intervention dictionary for term weight analysis.</description></item>
        /// <item><description>suggest_allowlist: a drop-down suggestion whitelist.</description></item>
        /// <item><description>suggest_denylist: a drop-down suggestion blacklist.</description></item>
        /// <item><description>hot_allowlist: a top search whitelist.</description></item>
        /// <item><description>hot_denylist: a top search blacklist.</description></item>
        /// <item><description>hint_allowlist: a hint whitelist.</description></item>
        /// <item><description>hint_denylist: a hint blacklist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ner</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
