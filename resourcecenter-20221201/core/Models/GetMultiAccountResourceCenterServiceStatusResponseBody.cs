// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceCenterServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The initialization status of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The feature is being initialized.</description></item>
        /// <item><description>Finished: The feature is initialized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("InitialStatus")]
        [Validation(Required=false)]
        public string InitialStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81671397-1425-51F1-A144-4799E01BEBFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The feature is enabled.</description></item>
        /// <item><description>Disabled: The feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
