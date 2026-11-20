// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantSceneDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code for API calls. You can obtain this code by calling the API operation to retrieve the authorization code for the English textbook-style AI teacher feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The list of scene IDs.</para>
        /// </summary>
        [NameInMap("sceneIdList")]
        [Validation(Required=false)]
        public List<string> SceneIdList { get; set; }

    }

}
