// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class OmniSearchQuery : TeaModel {
        /// <summary>
        /// <para>The request parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is the weather in Hangzhou today?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The session ID. This is a reserved field and is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session_id_123</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use CoT. This is a reserved field and is not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useCot")]
        [Validation(Required=false)]
        public bool? UseCot { get; set; }

        /// <summary>
        /// <para>The model version to use. Valid values: pro for the deep version, and lite for the fast version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("useModel")]
        [Validation(Required=false)]
        public string UseModel { get; set; }

    }

}
