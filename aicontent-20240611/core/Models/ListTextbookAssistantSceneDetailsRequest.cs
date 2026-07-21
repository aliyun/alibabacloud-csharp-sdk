// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantSceneDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The API authorization token. You can obtain the token by calling the operation that generates the token for the English Textbook-style AI Teacher feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>A list of scene IDs.</para>
        /// </summary>
        [NameInMap("sceneIdList")]
        [Validation(Required=false)]
        public List<string> SceneIdList { get; set; }

    }

}
