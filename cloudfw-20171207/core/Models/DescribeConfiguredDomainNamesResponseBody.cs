// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeConfiguredDomainNamesResponseBody : TeaModel {
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public List<DescribeConfiguredDomainNamesResponseBodyDomainNames> DomainNames { get; set; }
        public class DescribeConfiguredDomainNamesResponseBodyDomainNames : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsMalicious")]
            [Validation(Required=false)]
            public bool? IsMalicious { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public int? OperationTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sg_server</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>09A2D6F1-EA1B-56D9-977D-74878405****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
