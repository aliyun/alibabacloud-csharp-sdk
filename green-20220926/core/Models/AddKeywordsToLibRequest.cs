// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddKeywordsToLibRequest : TeaModel {
        /// <summary>
        /// <para>The keyword to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The name of the keyword file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upload/1e5353c0-0d91-40ba-9d41-ae7abd3fe561.txt</para>
        /// </summary>
        [NameInMap("KeywordsObject")]
        [Validation(Required=false)]
        public string KeywordsObject { get; set; }

        /// <summary>
        /// <para>The id of the keyword library.</para>
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
