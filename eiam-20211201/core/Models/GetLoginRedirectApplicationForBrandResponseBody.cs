// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetLoginRedirectApplicationForBrandResponseBody : TeaModel {
        [NameInMap("BrandLoginRedirectApplication")]
        [Validation(Required=false)]
        public GetLoginRedirectApplicationForBrandResponseBodyBrandLoginRedirectApplication BrandLoginRedirectApplication { get; set; }
        public class GetLoginRedirectApplicationForBrandResponseBodyBrandLoginRedirectApplication : TeaModel {
            /// <summary>
            /// <para>应用ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_xxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>品牌ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>brand_xxxx</para>
            /// </summary>
            [NameInMap("BrandId")]
            [Validation(Required=false)]
            public string BrandId { get; set; }

            /// <summary>
            /// <para>实例ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
