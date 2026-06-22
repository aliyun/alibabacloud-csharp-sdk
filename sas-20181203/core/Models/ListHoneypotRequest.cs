// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of honeypot IDs.</para>
        /// </summary>
        [NameInMap("HoneypotIds")]
        [Validation(Required=false)]
        public List<string> HoneypotIds { get; set; }

        /// <summary>
        /// <para>The name of the honeypot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx-rouyi</para>
        /// </summary>
        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        /// <summary>
        /// <para>The ID of the honeypot management node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a882e590-b87b-45a6-87b9-d0a3e5a0****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The name of the honeypot management node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>honeypot_master</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
