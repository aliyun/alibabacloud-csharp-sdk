// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DomainKnowledgeRetrieveRequest : TeaModel {
        /// <summary>
        /// <para>Le nombre de résultats à renvoyer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("GlobalTopN")]
        [Validation(Required=false)]
        public int? GlobalTopN { get; set; }

        /// <summary>
        /// <para>Les mots-clés à récupérer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment renouveler</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Les sites de la base de connaissances à interroger, y compris cn pour le national, intl pour l\&quot;international et all pour tous.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

    }

}
