// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetYaoChiAgentRequest : TeaModel {
        /// <summary>
        /// <para>The additional information in JSON string format. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        [NameInMap("ImageKeys")]
        [Validation(Required=false)]
        public string ImageKeys { get; set; }

        /// <summary>
        /// <para>The natural language description of the question.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Are there any issues or abnormalities with my instance rm-xxx?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The session ID in UUID string format. This parameter is optional. If you do not specify this parameter, a new session is created. To maintain context across a conversation, use the same session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The cloud service source that specifies which cloud service the question belongs to. This parameter is optional. Default value: yaochi.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yaochi</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
