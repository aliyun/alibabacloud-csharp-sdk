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

        /// <summary>
        /// <para>The system lines.</para>
        /// </summary>
        [NameInMap("SystemLines")]
        [Validation(Required=false)]
        public DescribeCloudGtmSystemLinesResponseBodySystemLines SystemLines { get; set; }
        public class DescribeCloudGtmSystemLinesResponseBodySystemLines : TeaModel {
            [NameInMap("SystemLine")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine> SystemLine { get; set; }
            public class DescribeCloudGtmSystemLinesResponseBodySystemLinesSystemLine : TeaModel {
                /// <summary>
                /// <para>The line code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun_r_ap-south-1</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The display name of the line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>Indicates whether the line can be selected as the source of a Domain Name System (DNS) request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                /// <summary>
                /// <para>The name of the line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The code of the parent line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>String	aliyun</para>
                /// </summary>
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
