// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateCloudauthstSceneRequest : TeaModel {
        /// <summary>
        /// <para>Product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMART_COMPARE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Scene name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("SceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <para>Whether to deliver the files generated from the authentication to the customer\&quot;s OSS:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable</description></item>
        /// <item><description><b>N</b>: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("StoreImage")]
        [Validation(Required=false)]
        public string StoreImage { get; set; }

    }

}
