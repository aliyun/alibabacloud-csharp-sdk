// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the protected object group.</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DescribeDefenseResourceGroupResponseBodyGroup Group { get; set; }
        public class DescribeDefenseResourceGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>The description of the protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the protected object group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23242312312</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The most recent time when the protected object group was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23242312312</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The name of the protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The protected objects in the protected object group. The protected objects are separated with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1.aliyundoc.com,test2.aliyundoc.com</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public string ResourceList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E67D21C6-5376-5F94-B745-70E08D03E3CB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
