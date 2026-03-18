// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmSystemLinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389DFFA3-77A5-4A9E-BF3D-147C6F98A5BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemLines")]
        [Validation(Required=false)]
        public DescribeCloudGtmSystemLinesResponseBodySystemLines SystemLines { get; set; }
        public class DescribeCloudGtmSystemLinesResponseBodySystemLines : TeaModel {
            [NameInMap("SystemLine")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine> SystemLine { get; set; }
            public class DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public string ParentCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The system lines, which are in a tree structure. Only a system line is listed in this example.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;displayName\&quot;:\&quot;Default\&quot;,\&quot;id\&quot;:\&quot;default\&quot;,\&quot;isAvailable\&quot;:true,\&quot;name\&quot;:\&quot;Default\&quot;,\&quot;parentId\&quot;:\&quot;\&quot;}]</para>
        /// </summary>
        [NameInMap("SystemLinesTree")]
        [Validation(Required=false)]
        public string SystemLinesTree { get; set; }

    }

}
