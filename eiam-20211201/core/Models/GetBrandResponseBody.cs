// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetBrandResponseBody : TeaModel {
        /// <summary>
        /// <para>Brand.</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public GetBrandResponseBodyBrand Brand { get; set; }
        public class GetBrandResponseBodyBrand : TeaModel {
            /// <summary>
            /// <para>Brand ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>brand_xxxx</para>
            /// </summary>
            [NameInMap("BrandId")]
            [Validation(Required=false)]
            public string BrandId { get; set; }

            /// <summary>
            /// <para>Brand name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Brand</para>
            /// </summary>
            [NameInMap("BrandName")]
            [Validation(Required=false)]
            public string BrandName { get; set; }

            /// <summary>
            /// <para>Brand type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("BrandType")]
            [Validation(Required=false)]
            public string BrandType { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Brand status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
