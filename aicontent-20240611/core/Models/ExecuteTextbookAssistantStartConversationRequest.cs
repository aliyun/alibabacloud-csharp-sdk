// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantStartConversationRequest : TeaModel {
        /// <summary>
        /// <para>How you obtain this ID depends on the value of <c>scenario</c>.</para>
        /// <para><b>When the <c>scenario</c> input parameter is <c>SYNC</c>:</b></para>
        /// <ol>
        /// <item><description><para>From the <c>Get Article List</c> response, use the top-level <c>articleId</c> field.</para>
        /// </description></item>
        /// <item><description><para>From the <c>Get Article Details</c> response, use the top-level <c>articleId</c> field.</para>
        /// </description></item>
        /// </ol>
        /// <para><b>When the <c>scenario</c> input parameter is <c>EXPAND</c>:</b></para>
        /// <ol>
        /// <item><description>From the <c>Get Article Details</c> response, use the <c>sceneid</c> field from an element in the <c>sceneList</c> array.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c05700d4d9411efbe6e0c42a106bb02</para>
        /// </summary>
        [NameInMap("articleId")]
        [Validation(Required=false)]
        public string ArticleId { get; set; }

        /// <summary>
        /// <para>The authorization token for the API call. Obtain this token by calling the operation that provides the authorization token for the textbook-style AI teacher feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tc_e6dc70c890866f4028ca685b6fa29874</para>
        /// </summary>
        [NameInMap("authToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The practice scenario. Valid values:</para>
        /// <para><c>SYNC</c>: synchronous practice</para>
        /// <para><c>EXPAND</c>: expansion practice</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYNC</para>
        /// </summary>
        [NameInMap("scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

    }

}
