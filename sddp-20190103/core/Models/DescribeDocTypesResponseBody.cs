// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDocTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of OSS file types in the result.</para>
        /// </summary>
        [NameInMap("DocTypeList")]
        [Validation(Required=false)]
        public List<DescribeDocTypesResponseBodyDocTypeList> DocTypeList { get; set; }
        public class DescribeDocTypesResponseBodyDocTypeList : TeaModel {
            /// <summary>
            /// <para>The file type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            /// <summary>
            /// <para>The unique ID of the file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The file type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C/C++ Source Code</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier that Alibaba Cloud generated for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
