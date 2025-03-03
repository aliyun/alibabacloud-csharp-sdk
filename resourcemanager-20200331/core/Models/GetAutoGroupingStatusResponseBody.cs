// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAutoGroupingStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the Transfer Existing Associated Resources feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableExistedResourcesTransfer")]
        [Validation(Required=false)]
        public bool? EnableExistedResourcesTransfer { get; set; }

        /// <summary>
        /// <para>The status of the Automatic Resource Transfer feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabling: The feature is being enabled.</description></item>
        /// <item><description>Enable: The feature is enabled.</description></item>
        /// <item><description>Partial_Enable: The transfer of associated resources is enabled, but custom transfer rule-based resource transfer is disabled. You can call the <a href="https://help.aliyun.com/document_detail/2870380.html">EnableAutoGrouping</a> operation to enable custom transfer rule-based resource transfer.</description></item>
        /// <item><description>Disable: The feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0217AFEB-5318-56D4-B167-1933D83EDF3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
