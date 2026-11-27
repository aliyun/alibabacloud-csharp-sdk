// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetAutoGroupingStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic grouping for existing resources is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableExistedResourcesTransfer")]
        [Validation(Required=false)]
        public bool? EnableExistedResourcesTransfer { get; set; }

        /// <summary>
        /// <para>The activation status of automatic grouping. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabling: Activating.</description></item>
        /// <item><description>Enable: Activated.</description></item>
        /// <item><description>Partial_Enable: Automatic grouping for associated resources is activated, but automatic grouping based on custom conditions is not activated. To activate automatic grouping based on custom conditions, call <a href="~~EnableAutoGrouping~~">EnableAutoGrouping</a>.</description></item>
        /// <item><description>Disable: Not activated.</description></item>
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
