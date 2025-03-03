// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateApiDestinationResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned response code. The value Success indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned if the API destination is created.</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public CreateApiDestinationResponseBodyDate Date { get; set; }
        public class CreateApiDestinationResponseBodyDate : TeaModel {
            /// <summary>
            /// <para>The name of the API destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApiDestinationName</para>
            /// </summary>
            [NameInMap("ApiDestinationName")]
            [Validation(Required=false)]
            public string ApiDestinationName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DAF96FB-A4B6-548C-B999-0BFDCB2261B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
