// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The quota dimensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;regionId\&quot;:\&quot;cn-beijing\&quot;}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaRequestDimensions> Dimensions { get; set; }
        public class GetProductQuotaRequestDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the dimension.</para>
            /// <remarks>
            /// <para> This parameter is required for cloud services that support dimensions. You must specify both <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c>. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. The following cloud services support dimensions: ECS whose service code is ecs, Enterprise Distributed Application Service (EDAS) whose service code is edas, ECS Quotas by Instance Type whose service code is ecs-spec, and Auto Scaling whose service code is ess.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the dimension.</para>
            /// <remarks>
            /// <para> This parameter is required for cloud services that support dimensions. You must specify both <c>Dimensions.N.Key</c> and <c>Dimensions.N.Value</c>. The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service. The following cloud services support dimensions: ECS whose service code is ecs, EDAS whose service code is edas, ECS Quotas by Instance Type whose service code is ecs-spec, and Auto Scaling whose service code is ess.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para> To query the abbreviation of an Alibaba Cloud service name, call the <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a> operation and check the value of <c>ProductCode</c> in the response.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota ID.</para>
        /// <remarks>
        /// <para> To query a quota ID of an Alibaba Cloud service, call the <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a> operation and check the value of <c>QuotaActionCode</c> in the response.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>q_security-groups</para>
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

    }

}
