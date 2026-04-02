// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListAIServicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListAIServicesResponseBodyServices> Services { get; set; }
        public class ListAIServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-03-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dramatest</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.0.1/api-docs</para>
            /// </summary>
            [NameInMap("PrivateApiDevUrl")]
            [Validation(Required=false)]
            public string PrivateApiDevUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("PrivateWorkbenchUrl")]
            [Validation(Required=false)]
            public string PrivateWorkbenchUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.8.8.8/api-docs</para>
            /// </summary>
            [NameInMap("PublicApiDevUrl")]
            [Validation(Required=false)]
            public string PublicApiDevUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.8.8.8</para>
            /// </summary>
            [NameInMap("PublicWorkbenchUrl")]
            [Validation(Required=false)]
            public string PublicWorkbenchUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIpList")]
            [Validation(Required=false)]
            public string SecurityIpList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dramauser</para>
            /// </summary>
            [NameInMap("ServiceAccount")]
            [Validation(Required=false)]
            public string ServiceAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>drama-123456</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
