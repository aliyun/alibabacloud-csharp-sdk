// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetMyTenantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The list of tenants.</para>
        /// </summary>
        [NameInMap("TenantList")]
        [Validation(Required=false)]
        public List<GetMyTenantsResponseBodyTenantList> TenantList { get; set; }
        public class GetMyTenantsResponseBodyTenantList : TeaModel {
            /// <summary>
            /// <para>The time when the tenant was deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("DeleteTime")]
            [Validation(Required=false)]
            public long? DeleteTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the tenant is deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <para>The tenant description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx 测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132311</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The tenant name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the tenant is an O&amp;M tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OpsTenant")]
            [Validation(Required=false)]
            public bool? OpsTenant { get; set; }

            /// <summary>
            /// <para>The ID of the user to whom the tenant belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21323231</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Indicates whether resource quota calculation is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ResourceLimited")]
            [Validation(Required=false)]
            public bool? ResourceLimited { get; set; }

            /// <summary>
            /// <para>The tenant types.</para>
            /// </summary>
            [NameInMap("TenantTypeList")]
            [Validation(Required=false)]
            public List<string> TenantTypeList { get; set; }

            /// <summary>
            /// <para>The title type of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icon</para>
            /// </summary>
            [NameInMap("TitleType")]
            [Validation(Required=false)]
            public string TitleType { get; set; }

            /// <summary>
            /// <para>Indicates whether the tenant is visible.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Visible")]
            [Validation(Required=false)]
            public bool? Visible { get; set; }

        }

    }

}
