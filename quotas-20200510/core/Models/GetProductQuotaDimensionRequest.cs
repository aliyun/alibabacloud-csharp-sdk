// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionRequest : TeaModel {
        /// <summary>
        /// <para>The information about quota dimensions.</para>
        /// </summary>
        [NameInMap("DependentDimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaDimensionRequestDependentDimensions> DependentDimensions { get; set; }
        public class GetProductQuotaDimensionRequestDependentDimensions : TeaModel {
            /// <summary>
            /// <para>The key of the quota dimension on which the quota dimension that you want to query is dependent.</para>
            /// <remarks>
            /// <para>The value range of N varies based on the number of quota dimensions that are supported by the specified Alibaba Cloud service.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension on which the quota dimension that you want to query is dependent.</para>
            /// <remarks>
            /// <para>The value range of N varies based on the number of quota dimensions that are supported by the specified Alibaba Cloud service.</para>
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
        /// <para>The key of the quota dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>regionId</para>
        /// </summary>
        [NameInMap("DimensionKey")]
        [Validation(Required=false)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/182368.html">Alibaba Cloud services that support Quota Center</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-spec</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
