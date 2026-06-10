// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotPidListResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.InvalidParameter</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHotspotPidListResponseBodyData Data { get; set; }
        public class GetHotspotPidListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of column names</para>
            /// </summary>
            [NameInMap("columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>List of process information</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<List<string>> Values { get; set; }

        }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
