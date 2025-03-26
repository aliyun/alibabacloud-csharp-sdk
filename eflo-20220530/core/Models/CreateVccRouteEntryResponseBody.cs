// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateVccRouteEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the failed permission verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateVccRouteEntryResponseBodyContent Content { get; set; }
        public class CreateVccRouteEntryResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The ID of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vcc-rte-5cey1sap</para>
            /// </summary>
            [NameInMap("VccRouteEntryId")]
            [Validation(Required=false)]
            public string VccRouteEntryId { get; set; }

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
        /// <para>039C3C3A-3C37-5672-80D5-D8CD48C676D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
