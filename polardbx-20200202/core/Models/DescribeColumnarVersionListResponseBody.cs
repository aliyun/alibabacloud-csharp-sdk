// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeColumnarVersionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeColumnarVersionListResponseBodyData Data { get; set; }
        public class DescribeColumnarVersionListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version list.</para>
            /// </summary>
            [NameInMap("VersionList")]
            [Validation(Required=false)]
            public List<string> VersionList { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-****-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
