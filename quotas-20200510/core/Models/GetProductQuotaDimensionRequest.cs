// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetProductQuotaDimensionRequest : Darabonba.Model {
        /// <summary>
        /// <para>The quota dimensions on which the target quota dimension depends.</para>
        /// </summary>
        [NameInMap("DependentDimensions")]
        [Validation(Required=false)]
        public List<GetProductQuotaDimensionRequestDependentDimensions> DependentDimensions { get; set; }
        public class GetProductQuotaDimensionRequestDependentDimensions : Darabonba.Model {
            /// <summary>
            /// <para>The key of the quota dimension on which the target quota dimension depends.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value of N depends on the number of quota dimensions on which the target quota dimension depends.</description></item>
            /// <item><description>You must specify the key and value of a dependent quota dimension at the same time.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the quota dimension on which the target quota dimension depends.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>The value of N depends on the number of quota dimensions on which the target quota dimension depends.</description></item>
            /// <item><description>You must specify the key and value of a dependent quota dimension at the same time.</description></item>
            /// </list>
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
        /// <para>The key of the target quota dimension.</para>
        /// <remarks>
        /// <para>If the target quota dimension has dependent quota dimensions, you must specify the keys and values of the dependent quota dimensions at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zoneId</para>
        /// </summary>
        [NameInMap("DimensionKey")]
        [Validation(Required=false)]
        public string DimensionKey { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviation of a cloud service, see the ProductCode parameter in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}

