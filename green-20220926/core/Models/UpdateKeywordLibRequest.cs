// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateKeywordLibRequest : TeaModel {
        /// <summary>
        /// <para>Library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Keyword library name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试库</para>
        /// </summary>
        [NameInMap("LibName")]
        [Validation(Required=false)]
        public string LibName { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
