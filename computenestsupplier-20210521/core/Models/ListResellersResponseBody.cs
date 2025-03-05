// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListResellersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAW8kZY+u1sYOaYf5JmgmDQQ=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A361BA9E-xxxx-xxxx-xxxx-C26E5180456E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>distributor informations</para>
        /// </summary>
        [NameInMap("SupplierInformation")]
        [Validation(Required=false)]
        public List<ListResellersResponseBodySupplierInformation> SupplierInformation { get; set; }
        public class ListResellersResponseBodySupplierInformation : TeaModel {
            /// <summary>
            /// <para>The description of distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>It is a XXXX  company</para>
            /// </summary>
            [NameInMap("SupplierDesc")]
            [Validation(Required=false)]
            public string SupplierDesc { get; set; }

            /// <summary>
            /// <para>The Logo of distributor</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-public.oss-cn-hangzhou.aliyuncs.com/31978070/service-image/d5c3b585-ff6b-4e4e-8885-xxxx.png">https://service-info-public.oss-cn-hangzhou.aliyuncs.com/31978070/service-image/d5c3b585-ff6b-4e4e-8885-xxxx.png</a></para>
            /// </summary>
            [NameInMap("SupplierLogo")]
            [Validation(Required=false)]
            public string SupplierLogo { get; set; }

            /// <summary>
            /// <para>The name of the distributor</para>
            /// 
            /// <b>Example:</b>
            /// <para>Distributor A</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>152xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("SupplierUid")]
            [Validation(Required=false)]
            public long? SupplierUid { get; set; }

            /// <summary>
            /// <para>The URL of the distributor.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
