// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the information of the alert rules that are configured for the site monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system returns the information of the alert rules that are configured for the site monitoring task.</description></item>
        /// <item><description>false (default): The system does not return the information of the alert rules that are configured for the site monitoring task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeAlert")]
        [Validation(Required=false)]
        public bool? IncludeAlert { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the site monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc641dff-c19d-45f3-ad0a-818a0c4f****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
