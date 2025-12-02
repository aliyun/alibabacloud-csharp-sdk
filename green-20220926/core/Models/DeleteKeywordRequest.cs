// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class DeleteKeywordRequest : TeaModel {
        /// <summary>
        /// <para>The ids\&quot; list of keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[6715465]</para>
        /// </summary>
        [NameInMap("KeywordIdList")]
        [Validation(Required=false)]
        public string KeywordIdList { get; set; }

        /// <summary>
        /// <para>The ids of keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[16754493]</para>
        /// </summary>
        [NameInMap("KeywordIds")]
        [Validation(Required=false)]
        public string KeywordIds { get; set; }

        /// <summary>
        /// <para>Library id</para>
        /// 
        /// <b>Example:</b>
        /// <para>customxx_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
