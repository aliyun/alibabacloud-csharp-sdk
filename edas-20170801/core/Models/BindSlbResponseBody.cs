// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindSlbResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindSlbResponseBodyData Data { get; set; }
        public class BindSlbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }

            /// <summary>
            /// <para>The IP address of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }

            /// <summary>
            /// <para>The name of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }

            /// <summary>
            /// <para>The ID of the vServer group for the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("ExtVServerGroupId")]
            [Validation(Required=false)]
            public string ExtVServerGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-wz96ph63r************</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The IP address of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.16*.<em>.</em></para>
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// <para>The name of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test**********</para>
            /// </summary>
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }

            /// <summary>
            /// <para>The listener port for the SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public int? SlbPort { get; set; }

            /// <summary>
            /// <para>The ID of the vServer group for the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bind slb success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23DR4FDXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
