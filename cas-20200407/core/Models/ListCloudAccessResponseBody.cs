// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the AccessKey pairs.</para>
        /// </summary>
        [NameInMap("CloudAccessList")]
        [Validation(Required=false)]
        public List<ListCloudAccessResponseBodyCloudAccessList> CloudAccessList { get; set; }
        public class ListCloudAccessResponseBodyCloudAccessList : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID used to access the cloud service.</para>
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
            /// <para>The AccessKey secret used to access the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI4G5KAZCJQqdwPBAXXXX</para>
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// <para>The status of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>The number of revoked certificates per page. Default value: <b>20</b>.</para>
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
