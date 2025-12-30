// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AlterSearchLibRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;faceGroupIds&quot;:&quot;xxx1,xxx2,xx3&quot;}</para>
        /// </summary>
        [NameInMap("SearchLibConfig")]
        [Validation(Required=false)]
        public string SearchLibConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
