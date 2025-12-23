// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListInterventionDictionariesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the intervention dictionary. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stopword: an intervention dictionary for stop word filtering</description></item>
        /// <item><description>synonym: an intervention dictionary for synonym configuration</description></item>
        /// <item><description>correction: an intervention dictionary for spelling correction</description></item>
        /// <item><description>category_prediction: an intervention dictionary for category prediction</description></item>
        /// <item><description>ner: an intervention dictionary for named entity recognition (NER)</description></item>
        /// <item><description>term_weighting: an intervention dictionary for term weight analysis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;synonym&quot;]</para>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
