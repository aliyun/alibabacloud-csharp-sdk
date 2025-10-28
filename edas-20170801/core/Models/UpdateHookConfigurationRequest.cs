// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateHookConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d498****-1dd8ec229862</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the application instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d498****-1dd8ec229862</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The script to mount. Set the value in the JSON format. Example: <c>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;postdeleteInstanceDataOnScaleIn&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestopInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststopInstance&quot;,&quot;script&quot;:&quot;&quot;}]</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;}]</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

    }

}
