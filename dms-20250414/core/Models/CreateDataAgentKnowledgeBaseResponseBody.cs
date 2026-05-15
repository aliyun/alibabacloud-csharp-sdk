// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentKnowledgeBaseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDataAgentKnowledgeBaseResponseBodyData Data { get; set; }
        public class CreateDataAgentKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>kb-HZ-ra99akg0t*********1bku</para>
            /// </summary>
            [NameInMap("KbUuid")]
            [Validation(Required=false)]
            public string KbUuid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
