// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeBindableSmartAccessGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9731C2F5-B9A4-42FD-AFD2-361A403E6E85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGateways SmartAccessGateways { get; set; }
        public class DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("SmartAccessGateway")]
            [Validation(Required=false)]
            public List<DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway> SmartAccessGateway { get; set; }
            public class DescribeBindableSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

                [NameInMap("SmartAGUid")]
                [Validation(Required=false)]
                public long? SmartAGUid { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of SAG instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
