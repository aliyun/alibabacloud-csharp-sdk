// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateSearchLibRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the search library. The value is in JSON string format. Fields:</para>
        /// <list type="bullet">
        /// <item><description>faceGroupIds: the IDs of self-registered face libraries created by calling CreateRecognitionLib. A maximum of three self-registered face library IDs are supported, separated by commas (,).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;faceGroupIds&quot;:&quot;xxx1,xxx2,xx3&quot;}</para>
        /// </summary>
        [NameInMap("SearchLibConfig")]
        [Validation(Required=false)]
        public string SearchLibConfig { get; set; }

        /// <summary>
        /// <para>The name of the search library. The name must be a combination of letters and digits. For network monitoring camera (IPC) scenarios, the prefix must be &quot;IPCamera_&quot;. For other scenarios, you can customize the name.</para>
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
