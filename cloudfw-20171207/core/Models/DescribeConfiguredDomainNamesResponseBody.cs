// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeConfiguredDomainNamesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public List<DescribeConfiguredDomainNamesResponseBodyDomainNames> DomainNames { get; set; }
        public class DescribeConfiguredDomainNamesResponseBodyDomainNames : TeaModel {
            /// <summary>
            /// <para>The comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is malicious. Valid values: <c>0</c> (not malicious) and <c>1</c> (malicious).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsMalicious")]
            [Validation(Required=false)]
            public bool? IsMalicious { get; set; }

            /// <summary>
            /// <para>The time of the operation, specified as a Unix timestamp in seconds. Example: <c>1672502400</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public int? OperationTime { get; set; }

        }

        /// <summary>
        /// <para>The application module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg_server</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09A2D6F1-EA1B-56D9-977D-74878405****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
