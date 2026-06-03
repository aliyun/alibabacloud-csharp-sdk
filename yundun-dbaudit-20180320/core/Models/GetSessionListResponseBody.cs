// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetSessionListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-06-06 00:00:00</para>
        /// </summary>
        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-06-06 23:59:59</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Incomplete")]
        [Validation(Required=false)]
        public string Incomplete { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1B217656-2267-4FBF-B26C-CDD201BDC3B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<GetSessionListResponseBodyResults> Results { get; set; }
        public class GetSessionListResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-06-06 00:00:00</para>
            /// </summary>
            [NameInMap("CaptureTime")]
            [Validation(Required=false)]
            public string CaptureTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("ClientIpAlias")]
            [Validation(Required=false)]
            public string ClientIpAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00163E06****</para>
            /// </summary>
            [NameInMap("ClientMac")]
            [Validation(Required=false)]
            public string ClientMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>administrator</para>
            /// </summary>
            [NameInMap("ClientOsUser")]
            [Validation(Required=false)]
            public string ClientOsUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15629</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public int? ClientPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>navicat</para>
            /// </summary>
            [NameInMap("ClientProgram")]
            [Validation(Required=false)]
            public string ClientProgram { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("DbUser")]
            [Validation(Required=false)]
            public string DbUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoginCode")]
            [Validation(Required=false)]
            public int? LoginCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Access denied for user \&quot;root\&quot;@\&quot;192.168.XX.XX\&quot;(using password: YES)</para>
            /// </summary>
            [NameInMap("LoginMessage")]
            [Validation(Required=false)]
            public string LoginMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ServerIp")]
            [Validation(Required=false)]
            public string ServerIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00163E06****</para>
            /// </summary>
            [NameInMap("ServerMac")]
            [Validation(Required=false)]
            public string ServerMac { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("ServerPort")]
            [Validation(Required=false)]
            public int? ServerPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3011610850021000000</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
