// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAutoGroupingStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the attached-resource allocation for existing resources is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableExistedResourcesTransfer")]
        [Validation(Required=false)]
        public bool? EnableExistedResourcesTransfer { get; set; }

        /// <summary>
        /// <para>The status of automatic resource group transfer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabling: Being enabled.</description></item>
        /// <item><description>Enable: Enabled.</description></item>
        /// <item><description>Partial_Enable: Attached-resource allocation is enabled, but custom condition-based resource group transfer is not enabled. To enable custom condition-based resource group transfer, call <a href="~~EnableAutoGrouping~~">EnableAutoGrouping</a>.</description></item>
        /// <item><description>Disable: Not enabled.</description></item>
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
