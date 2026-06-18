// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>requestid</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tag information.</para>
        /// </summary>
        [NameInMap("TagInfos")]
        [Validation(Required=false)]
        public List<DescribeTagsResponseBodyTagInfos> TagInfos { get; set; }
        public class DescribeTagsResponseBodyTagInfos : TeaModel {
            /// <summary>
            /// <para>The list of database instances associated with the tag.</para>
            /// </summary>
            [NameInMap("DBInstanceIds")]
            [Validation(Required=false)]
            public List<string> DBInstanceIds { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
