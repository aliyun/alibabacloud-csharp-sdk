// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("CloudAccessList")]
        [Validation(Required=false)]
        public List<ListCloudAccessResponseBodyCloudAccessList> CloudAccessList { get; set; }
        public class ListCloudAccessResponseBodyCloudAccessList : TeaModel {
            /// <summary>
            /// <para>The ID of the primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>888</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public long? AccessId { get; set; }

            /// <summary>
            /// <para>The cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tencent</para>
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// <para>The AccessKey ID that is used to access cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAqdwPBA****</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The service status. The value normal indicates that the service runs as expected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <para>The default value is the current page. If CurrentPage is not specified, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D3F1FA43-1C26-50A2-8F0F-7A03851DBB46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. If ShowSize is not specified, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
