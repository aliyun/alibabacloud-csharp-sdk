// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AlterSearchLibRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the search library, in JSON string format. The fields include the following:</para>
        /// <list type="bullet">
        /// <item><description>faceGroupIds: The IDs of custom face recognition libraries. You can create these libraries by calling the CreateRecognitionLib operation. You can specify up to three library IDs, separated by commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;faceGroupIds&quot;:&quot;xxx1,xxx2,xx3&quot;}</para>
        /// </summary>
        [NameInMap("SearchLibConfig")]
        [Validation(Required=false)]
        public string SearchLibConfig { get; set; }

        /// <summary>
        /// <para>The search library.</para>
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
