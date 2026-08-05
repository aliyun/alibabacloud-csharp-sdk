// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateCustomTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template configuration in JSON format. The value must be in the following format: {height:xxx,scale:xxx,gop:xxx,bframes:xxx,cdesc:xxx}. All fields are required. The call fails if any field is missing.</para>
        /// <remarks>
        /// <para>For more information about the parameters, see the <b>CustomTemplate details</b> table below.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;height&quot;:&quot;1060&quot;,&quot;scale&quot;:&quot;[16:9]&quot;,&quot;gop&quot;:&quot;60&quot;,&quot;bframes&quot;:&quot;30&quot;,&quot;cdesc&quot;:&quot;h264&quot;}</para>
        /// </summary>
        [NameInMap("CustomTemplate")]
        [Validation(Required=false)]
        public string CustomTemplate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the template to add.</para>
        /// <remarks>
        /// <para>Record the template name after you create it. The name is required for subsequent operations, such as using, querying, and deleting the template.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTemplate</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
