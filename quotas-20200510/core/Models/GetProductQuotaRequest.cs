// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaRequest : Darabonba.Model {
        /// <summary>
        /// <para>The quota dimensions.
        /// The properties of the quota item. The combination of dimensions and QuotaActionCode determines a unique quota item.</para>
        /// <remarks>
        /// <para>Dimensions are required for some cloud services. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions of a cloud service and check whether a dimension is required. The Requisite response parameter indicates whether the dimension is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;regionId\&quot;:\&quot;cn-beijing\&quot;}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaRequestDimensions> Dimensions { get; set; }
        public class GetProductQuotaRequestDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension.</para>
            /// <remarks>
            /// <para>You must specify both Dimensions.N.Key and Dimensions.N.Value. The value range of N depends on the number of dimensions supported by the cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions supported by the cloud service. The length of the returned array is the maximum value of N.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension.</para>
            /// <remarks>
            /// <para>You must specify both Dimensions.N.Key and Dimensions.N.Value. The value range of N depends on the number of dimensions supported by the cloud service. You can call the <a href="~~ListProductQuotaDimensions~~">ListProductQuotaDimensions</a> operation to query the quota dimensions supported by the cloud service. The length of the returned array is the maximum value of N.</para>
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
        /// <para>The abbreviated name of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviated name of a cloud service, see the ProductCode parameter in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
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
        /// <para>For more information about how to obtain the quota ID of a specified cloud service, see the QuotaActionCode parameter in <a href="https://help.aliyun.com/document_detail/440554.html">ListProductQuotas</a>.</para>
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

