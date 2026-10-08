// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DomainKnowledgeRetrieveResponseBody : TeaModel {
        /// <summary>
        /// <para>La liste des résultats récupérés.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DomainKnowledgeRetrieveResponseBodyData> Data { get; set; }
        public class DomainKnowledgeRetrieveResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Le score du texte récupéré ; plus le score est élevé, plus le résultat est pertinent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <para>La source des résultats récupérés.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Base de connaissances de l\&quot;activité nationale</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Le texte récupéré.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sur le site national d\&quot;Alibaba Cloud, le renouvellement de nom de domaine peut être effectué via les méthodes suivantes</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>L\&quot;identifiant de la requête.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FABCB-6C7D-18FE-AA42-922BFC9555D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
