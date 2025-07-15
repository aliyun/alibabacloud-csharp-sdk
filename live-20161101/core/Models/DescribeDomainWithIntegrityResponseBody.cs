// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeDomainWithIntegrityResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification information.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDomainWithIntegrityResponseBodyContent> Content { get; set; }
        public class DescribeDomainWithIntegrityResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The column names.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637825700000</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The subpoints.</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<string> Points { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
